﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodExtend
{
    internal static class ReflectionExtensions
    {
        public static void Deconstruct(this PropertyInfo p,  out bool isStatic, out bool isReadOnly, out bool isIndexed, out Type propertyType)
        {
            var getter = p.GetMethod;
            isReadOnly = !p.CanRead;
            isStatic = getter.IsStatic;
            isIndexed = p.GetIndexParameters().Length > 0;
            propertyType = p.PropertyType;
        }
        public static void Deconstruct(this PropertyInfo p, out bool hasGetAndSet, out bool sameAccess, out string access, out string getAccess, out string setAccess)
        {
            hasGetAndSet = sameAccess = false;
            string getAccessTemp = null;
            string setAccessTemp = null;
            MethodInfo getter = null;
            if (p.CanRead)
            {
                getter = p.GetMethod;
            }
            MethodInfo setter = null;
            if (p.CanWrite)
            {
                setter = p.SetMethod;
            }
            if (setter != null && getter != null)
            {
                hasGetAndSet = true;
            }
            if (getter != null)
            {
                if (getter.IsPublic)
                    getAccessTemp = "public";
                else if (getter.IsPrivate)
                    getAccessTemp = "private";
                else if (getter.IsAssembly)
                    getAccessTemp = "internal";
                else if (getter.IsFamily)
                    getAccessTemp = "protected";
                else if (getter.IsFamilyOrAssembly)
                    getAccessTemp = "protected internal";
            }

            if (setter != null)
            {
                if (setter.IsPublic)
                    setAccessTemp = "public";
                else if (setter.IsPrivate)
                    setAccessTemp = "private";
                else if (setter.IsAssembly)
                    setAccessTemp = "internal";
                else if (setter.IsFamily)
                    setAccessTemp = "protected";
                else if (setter.IsFamilyOrAssembly)
                    setAccessTemp = "protected internal";
            }
            if (setAccessTemp == getAccessTemp)
            {
                sameAccess = true;
                access = getAccessTemp;
                getAccess = setAccess = String.Empty;
            }
            else
            {
                access = null;
                getAccess = getAccessTemp;
                setAccess = setAccessTemp;
            }
            
        }
    }
}
