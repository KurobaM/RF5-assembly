using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CBD RID: 3261
	[Token(Token = "0x200085E")]
	public class FBIKBendGoal : MonoBehaviour
	{
		// Token: 0x060053D0 RID: 21456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E2")]
		[Address(RVA = "0x29B3740", Offset = "0x29B3841", VA = "0x29B3740")]
		private void Start()
		{
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E3")]
		[Address(RVA = "0x29B37B0", Offset = "0x29B38B1", VA = "0x29B37B0")]
		private void Update()
		{
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E4")]
		[Address(RVA = "0x29B38A0", Offset = "0x29B39A1", VA = "0x29B38A0")]
		public FBIKBendGoal()
		{
		}

		// Token: 0x0400B2CA RID: 45770
		[Token(Token = "0x400863E")]
		[FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		// Token: 0x0400B2CB RID: 45771
		[Token(Token = "0x400863F")]
		[FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		// Token: 0x0400B2CC RID: 45772
		[Token(Token = "0x4008640")]
		[FieldOffset(Offset = "0x24")]
		public float weight;
	}
}
