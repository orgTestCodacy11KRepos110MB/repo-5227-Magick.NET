﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace FileGenerator.Drawables
{
    public class MagickTypes
    {
        private readonly Assembly _magickNET;

        public MagickTypes()
        {
            AssemblyFile = GetFileName(@"src\Magick.NET\bin\ReleaseQ16\x64\netstandard20\Magick.NET-Q16-x64.dll");
            _magickNET = LoadAssembly();
        }

        protected string AssemblyFile { get; }

        public IEnumerable<Type> GetInterfaceTypes(string interfaceName)
            => _magickNET.GetTypes()
                .Where(type => type.IsPublic && !type.IsInterface && !type.IsAbstract)
                .OrderBy(type => type.Name)
                .Where(type => type.GetInterfaces().Any(interfaceType => interfaceType.Name == interfaceName));

        protected IEnumerable<Type> GetTypes()
            => _magickNET.GetTypes();

        private Assembly LoadAssembly()
        {
            var context = new AssemblyLoadContext("magick");
            context.Resolving += OnContextResolving;

            return context.LoadFromAssemblyPath(AssemblyFile);
        }

        private Assembly OnContextResolving(AssemblyLoadContext context, AssemblyName assemblyName)
        {
            if (assemblyName.Name == "Magick.NET.Core")
            {
                var fileName = GetFileName(@"src\Magick.NET.Core\bin\Release\AnyCPU\netstandard20\Magick.NET.Core.dll");
                return context.LoadFromAssemblyPath(fileName);
            }

            throw new NotImplementedException(assemblyName.Name);
        }

        private string GetFileName(string path)
        {
            var fileName = PathHelper.GetFullPath(path);
            if (!File.Exists(fileName))
                throw new InvalidOperationException("Unable to find file: " + AssemblyFile);

            return fileName;
        }
    }
}
