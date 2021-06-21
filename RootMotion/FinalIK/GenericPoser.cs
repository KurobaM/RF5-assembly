using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D6B RID: 3435
	[Token(Token = "0x20008D0")]
	public class GenericPoser : Poser
	{
		// Token: 0x06005926 RID: 22822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049EC")]
		[Address(RVA = "0x2C03800", Offset = "0x2C03901", VA = "0x2C03800", Slot = "7")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB420", Offset = "0x1AB521")]
		public override void AutoMapping()
		{
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049ED")]
		[Address(RVA = "0x2C03C50", Offset = "0x2C03D51", VA = "0x2C03C50", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049EE")]
		[Address(RVA = "0x2C03C60", Offset = "0x2C03D61", VA = "0x2C03C60", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		// Token: 0x06005929 RID: 22825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049EF")]
		[Address(RVA = "0x2C03F10", Offset = "0x2C04011", VA = "0x2C03F10", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F0")]
		[Address(RVA = "0x2C03BA0", Offset = "0x2C03CA1", VA = "0x2C03BA0")]
		private void StoreDefaultState()
		{
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049F1")]
		[Address(RVA = "0x2C03A50", Offset = "0x2C03B51", VA = "0x2C03A50")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F2")]
		[Address(RVA = "0x2C04060", Offset = "0x2C04161", VA = "0x2C04060")]
		public GenericPoser()
		{
		}

		// Token: 0x0400B86E RID: 47214
		[Token(Token = "0x4008A19")]
		[FieldOffset(Offset = "0x50")]
		public GenericPoser.Map[] maps;

		// Token: 0x02000D6C RID: 3436
		[Token(Token = "0x2001411")]
		[Serializable]
		public class Map
		{
			// Token: 0x0600592D RID: 22829 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A03")]
			[Address(RVA = "0x2C03B00", Offset = "0x2C03C01", VA = "0x2C03B00")]
			public Map(Transform bone, Transform target)
			{
			}

			// Token: 0x0600592E RID: 22830 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A04")]
			[Address(RVA = "0x2C04000", Offset = "0x2C04101", VA = "0x2C04000")]
			public void StoreDefaultState()
			{
			}

			// Token: 0x0600592F RID: 22831 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A05")]
			[Address(RVA = "0x2C03FB0", Offset = "0x2C040B1", VA = "0x2C03FB0")]
			public void FixTransform()
			{
			}

			// Token: 0x06005930 RID: 22832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A06")]
			[Address(RVA = "0x2C03D70", Offset = "0x2C03E71", VA = "0x2C03D70")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}

			// Token: 0x0400B86F RID: 47215
			[Token(Token = "0x401BA87")]
			[FieldOffset(Offset = "0x10")]
			public Transform bone;

			// Token: 0x0400B870 RID: 47216
			[Token(Token = "0x401BA88")]
			[FieldOffset(Offset = "0x18")]
			public Transform target;

			// Token: 0x0400B871 RID: 47217
			[Token(Token = "0x401BA89")]
			[FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			// Token: 0x0400B872 RID: 47218
			[Token(Token = "0x401BA8A")]
			[FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;
		}
	}
}
