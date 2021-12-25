using AbrstractFactory.AbstractFactory;
using AbrstractFactory.AbstractProduct;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace AbrstractFactory
{
    public static class DbProviderFactoriesS
    {
        private struct ProviderRegistration
        {
            internal ProviderRegistration(string factoryTypeAssemblyQualifiedName, DbProviderFactoryS factoryInstance)
            {
                this.FactoryTypeAssemblyQualifiedName = factoryTypeAssemblyQualifiedName;
                this.FactoryInstance = factoryInstance;
            }
            
            internal string FactoryTypeAssemblyQualifiedName { get; }
                        
            internal DbProviderFactoryS FactoryInstance { get; }
        }

        private static readonly ConcurrentDictionary<string, ProviderRegistration> _registeredFactories = new ConcurrentDictionary<string, ProviderRegistration>();
        private const string AssemblyQualifiedNameColumnName = "AssemblyQualifiedName";
        private const string InstanceFieldName = "Instance";


        public static DbProviderFactoryS GetFactory(string providerInvariantName)
        {
            return GetFactory(providerInvariantName,  true);
        }

        private static DbProviderFactoryS GetFactoryInstance(Type providerFactoryClass)
        {          

            FieldInfo providerInstance = providerFactoryClass.GetField(InstanceFieldName, BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Static);
            
            object factory = providerInstance.GetValue(null);
            
            return (DbProviderFactoryS)factory;
        }

        private static Type GetProviderTypeFromTypeName(string assemblyQualifiedName)
        {
            Type providerType = Type.GetType(assemblyQualifiedName);
            
            return providerType;
        }

        public static bool UnregisterFactory(string providerInvariantName)
        {
            return !string.IsNullOrWhiteSpace(providerInvariantName) && _registeredFactories.TryRemove(providerInvariantName, out _);
        }

        private static DbProviderFactoryS GetFactory(string providerInvariantName, bool throwOnError)
        {
            
            bool wasRegistered = _registeredFactories.TryGetValue(providerInvariantName, out ProviderRegistration registration);
            
            DbProviderFactoryS toReturn = registration.FactoryInstance;
            if (toReturn == null)
            {
               toReturn = GetFactoryInstance(GetProviderTypeFromTypeName(registration.FactoryTypeAssemblyQualifiedName));
                RegisterFactory(providerInvariantName, toReturn);
            }
            return toReturn;
        }

        public static void RegisterFactory(string providerInvariantName, DbProviderFactoryS factory)
        {       

            string factoryTypeAssemblyQualifiedName = factory.GetType().AssemblyQualifiedName;
            _registeredFactories[providerInvariantName] = new ProviderRegistration(factoryTypeAssemblyQualifiedName, factory);
        }
    }
}
