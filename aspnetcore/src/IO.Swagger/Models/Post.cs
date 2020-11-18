/*
 * Сервис задач и уведомлений
 *
 * API сервиса для получения и создания задач и отправки уведомлений
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Post : IEquatable<Post>
    { 
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Assignees
        /// </summary>
        [Required]
        [DataMember(Name="assignees")]
        public Assignees Assignees { get; set; }

        /// <summary>
        /// Gets or Sets ActionTypeId
        /// </summary>
        [Required]
        [DataMember(Name="actionTypeId")]
        public int? ActionTypeId { get; set; }

        /// <summary>
        /// Gets or Sets Statuses
        /// </summary>
        [Required]
        [DataMember(Name="statuses")]
        public Statuses Statuses { get; set; }

        /// <summary>
        /// Gets or Sets Report
        /// </summary>
        [DataMember(Name="report")]
        public string Report { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content")]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Post {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Assignees: ").Append(Assignees).Append("\n");
            sb.Append("  ActionTypeId: ").Append(ActionTypeId).Append("\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  Report: ").Append(Report).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Post)obj);
        }

        /// <summary>
        /// Returns true if Post instances are equal
        /// </summary>
        /// <param name="other">Instance of Post to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Post other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Assignees == other.Assignees ||
                    Assignees != null &&
                    Assignees.Equals(other.Assignees)
                ) && 
                (
                    ActionTypeId == other.ActionTypeId ||
                    ActionTypeId != null &&
                    ActionTypeId.Equals(other.ActionTypeId)
                ) && 
                (
                    Statuses == other.Statuses ||
                    Statuses != null &&
                    Statuses.Equals(other.Statuses)
                ) && 
                (
                    Report == other.Report ||
                    Report != null &&
                    Report.Equals(other.Report)
                ) && 
                (
                    Content == other.Content ||
                    Content != null &&
                    Content.Equals(other.Content)
                ) && 
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.Equals(other.Comment)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Assignees != null)
                    hashCode = hashCode * 59 + Assignees.GetHashCode();
                    if (ActionTypeId != null)
                    hashCode = hashCode * 59 + ActionTypeId.GetHashCode();
                    if (Statuses != null)
                    hashCode = hashCode * 59 + Statuses.GetHashCode();
                    if (Report != null)
                    hashCode = hashCode * 59 + Report.GetHashCode();
                    if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Post left, Post right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Post left, Post right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
