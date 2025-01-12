// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The video rate control mode. </summary>
    public readonly partial struct H264RateControlMode : IEquatable<H264RateControlMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="H264RateControlMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public H264RateControlMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ABRValue = "ABR";
        private const string CBRValue = "CBR";
        private const string CRFValue = "CRF";

        /// <summary> Average Bitrate (ABR) mode that hits the target bitrate: Default mode. </summary>
        public static H264RateControlMode ABR { get; } = new H264RateControlMode(ABRValue);
        /// <summary> Constant Bitrate (CBR) mode that tightens bitrate variations around target bitrate. </summary>
        public static H264RateControlMode CBR { get; } = new H264RateControlMode(CBRValue);
        /// <summary> Constant Rate Factor (CRF) mode that targets at constant subjective quality. </summary>
        public static H264RateControlMode CRF { get; } = new H264RateControlMode(CRFValue);
        /// <summary> Determines if two <see cref="H264RateControlMode"/> values are the same. </summary>
        public static bool operator ==(H264RateControlMode left, H264RateControlMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="H264RateControlMode"/> values are not the same. </summary>
        public static bool operator !=(H264RateControlMode left, H264RateControlMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="H264RateControlMode"/>. </summary>
        public static implicit operator H264RateControlMode(string value) => new H264RateControlMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is H264RateControlMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(H264RateControlMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
