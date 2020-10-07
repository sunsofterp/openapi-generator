/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Triangle
    /// </summary>
    [DataContract(Name = "Triangle")]
    public partial class Triangle : AbstractOpenAPISchema, IEquatable<Triangle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class.
        /// </summary>
        public Triangle()
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle" /> class.
        /// </summary>
        /// <param name="actualInstance">The actual instance.</param>
        public Triangle(Object actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";

            if (actualInstance == null)
            {
                return;
            }

            if (actualInstance.GetType() == typeof(EquilateralTriangle))
            {
                 this.ActualInstance = actualInstance;
                 return;
            }

            if (actualInstance.GetType() == typeof(IsoscelesTriangle))
            {
                 this.ActualInstance = actualInstance;
                 return;
            }

            if (actualInstance.GetType() == typeof(ScaleneTriangle))
            {
                 this.ActualInstance = actualInstance;
                 return;
            }

            throw new ArgumentException("Invalid instance found. Must be the following types: EquilateralTriangle IsoscelesTriangle ScaleneTriangle");
        }

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return ActualInstance;
            }
            set
            {

                if (value.GetType() == typeof(EquilateralTriangle))
                {
                     this.ActualInstance = value;
                     return;
                }

                if (value.GetType() == typeof(IsoscelesTriangle))
                {
                     this.ActualInstance = value;
                     return;
                }

                if (value.GetType() == typeof(ScaleneTriangle))
                {
                     this.ActualInstance = value;
                     return;
                }

                throw new ArgumentException("Invalid instance found. Must be the following types: EquilateralTriangle IsoscelesTriangle ScaleneTriangle");
            }
        }

        /// <summary>
        /// Get the actual instance of `EquilateralTriangle`. If the actual instanct is not `EquilateralTriangle`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EquilateralTriangle</returns>
        public EquilateralTriangle GetEquilateralTriangle()
        {
            return (EquilateralTriangle)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `IsoscelesTriangle`. If the actual instanct is not `IsoscelesTriangle`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IsoscelesTriangle</returns>
        public IsoscelesTriangle GetIsoscelesTriangle()
        {
            return (IsoscelesTriangle)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ScaleneTriangle`. If the actual instanct is not `ScaleneTriangle`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ScaleneTriangle</returns>
        public ScaleneTriangle GetScaleneTriangle()
        {
            return (ScaleneTriangle)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Triangle {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance);
        }

        /// <summary>
        /// Converts the JSON string into the object
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        public override void FromJson(string jsonString)
        {
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                this.ActualInstance = JsonConvert.DeserializeObject<EquilateralTriangle>(jsonString);
                matchedTypes.Add("EquilateralTriangle");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                // uncomment the line below for troubleshooting
                //Console.WriteLine(exception.ToString());
            }

            try
            {
                this.ActualInstance = JsonConvert.DeserializeObject<IsoscelesTriangle>(jsonString);
                matchedTypes.Add("IsoscelesTriangle");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                // uncomment the line below for troubleshooting
                //Console.WriteLine(exception.ToString());
            }

            try
            {
                this.ActualInstance = JsonConvert.DeserializeObject<ScaleneTriangle>(jsonString);
                matchedTypes.Add("ScaleneTriangle");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                // uncomment the line below for troubleshooting
                //Console.WriteLine(exception.ToString());
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }
            
            // deserialization is considered successful at this point if no exception has been thrown.
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Triangle).AreEqual;
        }

        /// <summary>
        /// Returns true if Triangle instances are equal
        /// </summary>
        /// <param name="input">Instance of Triangle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Triangle input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
