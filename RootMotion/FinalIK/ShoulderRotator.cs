using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000DA1 RID: 3489
	[Token(Token = "0x20008E7")]
	public class ShoulderRotator : MonoBehaviour
	{
		// Token: 0x06005A44 RID: 23108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A8D")]
		[Address(RVA = "0x27CF290", Offset = "0x27CF391", VA = "0x27CF290")]
		private void Start()
		{
		}

		// Token: 0x06005A45 RID: 23109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A8E")]
		[Address(RVA = "0x27CF390", Offset = "0x27CF491", VA = "0x27CF390")]
		private void RotateShoulders()
		{
		}

		// Token: 0x06005A46 RID: 23110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A8F")]
		[Address(RVA = "0x27CF480", Offset = "0x27CF581", VA = "0x27CF480")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A90")]
		[Address(RVA = "0x27CF910", Offset = "0x27CFA11", VA = "0x27CF910")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		// Token: 0x06005A48 RID: 23112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A91")]
		[Address(RVA = "0x27CF950", Offset = "0x27CFA51", VA = "0x27CF950")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005A49 RID: 23113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A92")]
		[Address(RVA = "0x27CFA70", Offset = "0x27CFB71", VA = "0x27CFA70")]
		public ShoulderRotator()
		{
		}

		// Token: 0x0400B995 RID: 47509
		[Token(Token = "0x4008AA8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17CA10", Offset = "0x17CB11")]
		public float weight;

		// Token: 0x0400B996 RID: 47510
		[Token(Token = "0x4008AA9")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17CA50", Offset = "0x17CB51")]
		public float offset;

		// Token: 0x0400B997 RID: 47511
		[Token(Token = "0x4008AAA")]
		[FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		// Token: 0x0400B998 RID: 47512
		[Token(Token = "0x4008AAB")]
		[FieldOffset(Offset = "0x28")]
		private bool skip;
	}
}
