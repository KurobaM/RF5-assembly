using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D25 RID: 3365
	[Token(Token = "0x20008AF")]
	[Serializable]
	public class FABRIKChain
	{
		// Token: 0x0600563E RID: 22078 RVA: 0x0001C620 File Offset: 0x0001A820
		[Token(Token = "0x60047EA")]
		[Address(RVA = "0x2872890", Offset = "0x2872991", VA = "0x2872890")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047EB")]
		[Address(RVA = "0x2872970", Offset = "0x2872A71", VA = "0x2872970")]
		public void Initiate()
		{
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047EC")]
		[Address(RVA = "0x2872990", Offset = "0x2872A91", VA = "0x2872990")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047ED")]
		[Address(RVA = "0x2872DB0", Offset = "0x2872EB1", VA = "0x2872DB0")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		// Token: 0x06005642 RID: 22082 RVA: 0x0001C638 File Offset: 0x0001A838
		[Token(Token = "0x60047EE")]
		[Address(RVA = "0x2872A70", Offset = "0x2872B71", VA = "0x2872A70")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		// Token: 0x06005643 RID: 22083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047EF")]
		[Address(RVA = "0x2872EC0", Offset = "0x2872FC1", VA = "0x2872EC0")]
		public FABRIKChain()
		{
		}

		// Token: 0x0400B587 RID: 46471
		[Token(Token = "0x4008869")]
		[FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		// Token: 0x0400B588 RID: 46472
		[Token(Token = "0x400886A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A060", Offset = "0x17A161")]
		public float pull;

		// Token: 0x0400B589 RID: 46473
		[Token(Token = "0x400886B")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A080", Offset = "0x17A181")]
		public float pin;

		// Token: 0x0400B58A RID: 46474
		[Token(Token = "0x400886C")]
		[FieldOffset(Offset = "0x20")]
		public int[] children;
	}
}
