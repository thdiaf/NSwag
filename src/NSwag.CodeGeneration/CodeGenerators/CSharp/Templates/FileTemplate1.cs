﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace NSwag.CodeGeneration.CodeGenerators.CSharp.Templates
{
    using NJsonSchema;
    using NJsonSchema.CodeGeneration;
    using NSwag.CodeGeneration.CodeGenerators.CSharp;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    internal partial class FileTemplate : FileTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("//----------------------\r\n// <auto-generated>\r\n//     Generated using the NSwag t" +
                    "oolchain v");
            
            #line 8 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SwaggerService.ToolchainVersion));
            
            #line default
            #line hidden
            this.Write(" (NJsonSchema v");
            
            #line 8 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(JsonSchema4.ToolchainVersion));
            
            #line default
            #line hidden
            this.Write(@") (http://NSwag.org)
// </auto-generated>
//----------------------

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
");
            
            #line 33 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
foreach(var usage in Model.NamespaceUsages){
            
            #line default
            #line hidden
            this.Write("using ");
            
            #line 33 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(usage));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 34 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 36 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    #pragma warning disable // Disable all warnings\r\n\r\n    ");
            
            #line 40 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConversionUtilities.Tab(Model.Clients, 1)));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 42 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
if(Model.GenerateContracts){
            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 43 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConversionUtilities.Tab(Model.Classes, 1)));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n    [GeneratedCode(\"NSwag\", \"");
            
            #line 45 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SwaggerService.ToolchainVersion));
            
            #line default
            #line hidden
            this.Write(@""")]
    public class FileParameter
    {
        public FileParameter(Stream data) 
            : this (data, null)
        {
        }

        public FileParameter(Stream data, string fileName)
        {
            Data = data;
            FileName = fileName;
        }

        public Stream Data { get; private set; }

        public string FileName { get; private set; }
    }

    [GeneratedCode(""NSwag"", """);
            
            #line 64 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SwaggerService.ToolchainVersion));
            
            #line default
            #line hidden
            this.Write(@""")]
    public class SwaggerException : Exception
    {
        public string StatusCode { get; private set; }

        public byte[] ResponseData { get; private set; }

        public SwaggerException(string message, string statusCode, byte[] responseData, Exception innerException) 
            : base(message, innerException)
        {
            StatusCode = statusCode;
            ResponseData = responseData;
        }

        public override string ToString()
        {
            return string.Format(""HTTP Response: n{0}n{1}"", Encoding.UTF8.GetString(ResponseData, 0, ResponseData.Length), base.ToString());
        }
    }

    [GeneratedCode(""NSwag"", """);
            
            #line 84 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SwaggerService.ToolchainVersion));
            
            #line default
            #line hidden
            this.Write(@""")]
    public class SwaggerException<TResponse> : SwaggerException
    {
        public TResponse Response { get; private set; }

        public SwaggerException(string message, string statusCode, byte[] responseData, TResponse response, Exception innerException) 
            : base(message, statusCode, responseData, innerException)
        {
            Response = response;
        }
    }

");
            
            #line 96 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 97 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
if(Model.GenerateImplementation){
            
            #line default
            #line hidden
            
            #line 98 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
  if(Model.RequiresJsonExceptionConverter){
            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 99 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SwaggerToCSharpClientGenerator.GetJsonExceptionConverterCode(1)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 100 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
  }
            
            #line default
            #line hidden
            
            #line 101 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration\CodeGenerators\CSharp\Templates\FileTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    internal class FileTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}