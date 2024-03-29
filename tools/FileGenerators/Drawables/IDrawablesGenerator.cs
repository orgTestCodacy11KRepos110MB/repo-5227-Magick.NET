﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System.Linq;
using System.Reflection;

namespace FileGenerator.Drawables
{
    internal sealed class IDrawablesGenerator : DrawableCodeGenerator
    {
        private IDrawablesGenerator()
            : base(true)
        {
        }

        public static void Generate()
        {
            var generator = new IDrawablesGenerator();
            generator.CreateWriter(PathHelper.GetFullPath(@"src\Magick.NET.Core\Drawables\Generated\IDrawables{TQuantumType}.cs"));
            Generate(generator);
        }

        protected override void WriteUsing()
        {
            WriteLine("using System.Collections.Generic;");
            WriteLine("using System.Text;");
            WriteLine();
        }

        private static void Generate(IDrawablesGenerator generator)
        {
            generator.WriteStart("ImageMagick");
            generator.WriteDrawables();
            generator.WriteEnd();

            generator.CloseWriter();
        }

        private bool IsValid(ConstructorInfo constructor)
        {
            var parameters = constructor.GetParameters();
            if (parameters.Length == 0)
                return constructor.DeclaringType!.GetConstructors().Count() == 1;

            return true;
        }

        private void WriteDrawable(ConstructorInfo constructor)
        {
            if (!IsValid(constructor))
                return;

            var name = constructor.DeclaringType!.Name.Substring(8);
            var parameters = constructor.GetParameters();

            foreach (var commentLine in Types.GetCommentLines(constructor, "IDrawables{TQuantumType}"))
                WriteLine(commentLine);
            Write("IDrawables<TQuantumType> " + name + "(");
            WriteParameterDeclaration(parameters);
            WriteLine(");");
            WriteLine();
        }

        private void WriteDrawable(PropertyInfo property)
        {
            var name = property.Name.Replace("led", "le") + property.PropertyType.Name.Substring(8);

            foreach (var commentLine in Types.GetCommentLines(property, "IDrawables{TQuantumType}"))
                WriteLine(commentLine);
            WriteLine("IDrawables<TQuantumType> " + name + "();");
            WriteLine();
        }

        private void WriteDrawables()
        {
            WriteLine(@"[System.CodeDom.Compiler.GeneratedCode(""Magick.NET.FileGenerator"", """")]");

            WriteLine("public partial interface IDrawables<TQuantumType>");
            WriteStartColon();

            foreach (var drawable in Types.GetDrawableConstructors())
            {
                WriteDrawable(drawable);
            }

            foreach (var drawable in Types.GetStaticDrawableConstructors())
            {
                WriteDrawable(drawable);
            }

            WriteEndColon();
        }
    }
}
