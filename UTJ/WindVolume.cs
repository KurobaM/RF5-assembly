using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000BD7 RID: 3031
	[Token(Token = "0x20007E2")]
	public class WindVolume : ForceProvider
	{
		// Token: 0x06004D56 RID: 19798 RVA: 0x00018A50 File Offset: 0x00016C50
		[Token(Token = "0x60040DF")]
		[Address(RVA = "0x23B79D0", Offset = "0x23B7AD1", VA = "0x23B79D0", Slot = "4")]
		public override Vector3 GetForceOnBone(SpringBone springBone)
		{
			return default(Vector3);
		}

		// Token: 0x06004D57 RID: 19799 RVA: 0x00018A68 File Offset: 0x00016C68
		[Token(Token = "0x60040E0")]
		[Address(RVA = "0x23B7C60", Offset = "0x23B7D61", VA = "0x23B7C60")]
		private float GetPositionalFactor(float x, float y)
		{
			return 0f;
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x00018A80 File Offset: 0x00016C80
		[Token(Token = "0x60040E1")]
		[Address(RVA = "0x23B7D00", Offset = "0x23B7E01", VA = "0x23B7D00")]
		private float AddPeriodically(float currentValue, float deltaValue, float period)
		{
			return 0f;
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E2")]
		[Address(RVA = "0x23B7D20", Offset = "0x23B7E21", VA = "0x23B7D20")]
		private void Update()
		{
		}

		// Token: 0x06004D5A RID: 19802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E3")]
		[Address(RVA = "0x23B7FE0", Offset = "0x23B80E1", VA = "0x23B7FE0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E4")]
		[Address(RVA = "0x23B8310", Offset = "0x23B8411", VA = "0x23B8310")]
		public WindVolume()
		{
		}

		// Token: 0x0400AEE0 RID: 44768
		[Token(Token = "0x40083ED")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x176C90", Offset = "0x176D91")]
		public float weight;

		// Token: 0x0400AEE1 RID: 44769
		[Token(Token = "0x40083EE")]
		[FieldOffset(Offset = "0x1C")]
		public float strength;

		// Token: 0x0400AEE2 RID: 44770
		[Token(Token = "0x40083EF")]
		[FieldOffset(Offset = "0x20")]
		public float amplitude;

		// Token: 0x0400AEE3 RID: 44771
		[Token(Token = "0x40083F0")]
		[FieldOffset(Offset = "0x24")]
		public float period;

		// Token: 0x0400AEE4 RID: 44772
		[Token(Token = "0x40083F1")]
		[FieldOffset(Offset = "0x28")]
		public float spinPeriod;

		// Token: 0x0400AEE5 RID: 44773
		[Token(Token = "0x40083F2")]
		[FieldOffset(Offset = "0x2C")]
		public float peakDistance;

		// Token: 0x0400AEE6 RID: 44774
		[Token(Token = "0x40083F3")]
		private const float PI2 = 6.28318548f;

		// Token: 0x0400AEE7 RID: 44775
		[Token(Token = "0x40083F4")]
		[FieldOffset(Offset = "0x30")]
		private float positionalMultiplier;

		// Token: 0x0400AEE8 RID: 44776
		[Token(Token = "0x40083F5")]
		[FieldOffset(Offset = "0x34")]
		private float currentTime;

		// Token: 0x0400AEE9 RID: 44777
		[Token(Token = "0x40083F6")]
		[FieldOffset(Offset = "0x38")]
		private float timeFactor;

		// Token: 0x0400AEEA RID: 44778
		[Token(Token = "0x40083F7")]
		[FieldOffset(Offset = "0x3C")]
		private float spinTime;

		// Token: 0x0400AEEB RID: 44779
		[Token(Token = "0x40083F8")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 offsetVector;
	}
}
