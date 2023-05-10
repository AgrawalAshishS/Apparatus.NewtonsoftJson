// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectExtensions.cs" company="Toshal Infotech">
//   http://www.ToshalInfotech.com
//   Copyright (c) 2022-23
//   by Toshal Infotech
//   
//   Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
//   documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
//   the rights to use, copy, modify, merge, publish, distribute, sub-license, and/or sell copies of the Software, and 
//   to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//   
//   The above copyright notice and this permission notice shall be included in all copies or substantial portions 
//   of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
//   TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
//   THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
//   CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
//   DEALINGS IN THE SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using Newtonsoft.Json;

namespace Apparatus
{

    /// <summary>
    /// Extension methods of Object class; so for everything.
    /// </summary>
    public static class ObjectExtensions
    {
        private static readonly JsonSerializerSettings defaultJsonOption = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        /// <summary>
        /// Returns JSON string representation of object. This is done using Newtonsoft.Json.
        /// </summary>
        public static string ToJson(this object src)
        {
            return JsonConvert.SerializeObject(src, defaultJsonOption);
        }

        /// <summary>
        /// Returns JSON string representation of object. This is done using Newtonsoft.Json.
        /// </summary>
        public static string ToJson(this object src, JsonSerializerSettings jsonSetting)
        {
            return JsonConvert.SerializeObject(src, jsonSetting);
        }

        /// <summary>
        /// Creates new object based on given type and load JSON data.
        /// </summary>
        public static object ObjectFromJson(this Type type, string data)
        {
            return JsonConvert.DeserializeObject(data, type);
        }
    }
}