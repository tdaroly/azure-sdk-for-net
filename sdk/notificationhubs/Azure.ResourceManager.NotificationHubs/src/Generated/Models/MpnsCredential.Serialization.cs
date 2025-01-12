// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class MpnsCredential : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(MpnsCertificate))
            {
                writer.WritePropertyName("mpnsCertificate");
                writer.WriteStringValue(MpnsCertificate);
            }
            if (Optional.IsDefined(CertificateKey))
            {
                writer.WritePropertyName("certificateKey");
                writer.WriteStringValue(CertificateKey);
            }
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint");
                writer.WriteStringValue(Thumbprint);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MpnsCredential DeserializeMpnsCredential(JsonElement element)
        {
            Optional<string> mpnsCertificate = default;
            Optional<string> certificateKey = default;
            Optional<string> thumbprint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("mpnsCertificate"))
                        {
                            mpnsCertificate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("certificateKey"))
                        {
                            certificateKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"))
                        {
                            thumbprint = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MpnsCredential(mpnsCertificate.Value, certificateKey.Value, thumbprint.Value);
        }
    }
}
