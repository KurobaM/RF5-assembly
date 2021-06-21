using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Fishing
{
	// Token: 0x02001073 RID: 4211
	[Token(Token = "0x2000AAC")]
	public class WkiMove : MonoBehaviour
	{
		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06006A45 RID: 27205 RVA: 0x00024558 File Offset: 0x00022758
		// (set) Token: 0x06006A46 RID: 27206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A9F")]
		public Vector3 Velocity
		{
			[Token(Token = "0x600588B")]
			[Address(RVA = "0x1EC6A30", Offset = "0x1EC6B31", VA = "0x1EC6A30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD7F0", Offset = "0x1AD8F1")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600588C")]
			[Address(RVA = "0x1EC6A40", Offset = "0x1EC6B41", VA = "0x1EC6A40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD800", Offset = "0x1AD901")]
			protected set
			{
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06006A47 RID: 27207 RVA: 0x00024570 File Offset: 0x00022770
		// (set) Token: 0x06006A48 RID: 27208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AA0")]
		public Vector3 Gravity
		{
			[Token(Token = "0x600588D")]
			[Address(RVA = "0x1EC6A50", Offset = "0x1EC6B51", VA = "0x1EC6A50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD810", Offset = "0x1AD911")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600588E")]
			[Address(RVA = "0x1EC6A60", Offset = "0x1EC6B61", VA = "0x1EC6A60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD820", Offset = "0x1AD921")]
			protected set
			{
			}
		}

		// Token: 0x06006A49 RID: 27209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600588F")]
		[Address(RVA = "0x1EC5A90", Offset = "0x1EC5B91", VA = "0x1EC5A90")]
		public void Reset(Vector3 pos, Quaternion dir)
		{
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005890")]
		[Address(RVA = "0x1EC5DD0", Offset = "0x1EC5ED1", VA = "0x1EC5DD0")]
		public void OnUpdate()
		{
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005891")]
		[Address(RVA = "0x1EC6A70", Offset = "0x1EC6B71", VA = "0x1EC6A70")]
		private void UpdateAngle()
		{
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x00024588 File Offset: 0x00022788
		[Token(Token = "0x6005892")]
		[Address(RVA = "0x1EC6C10", Offset = "0x1EC6D11", VA = "0x1EC6C10")]
		private float getAngle(float x, float y)
		{
			return 0f;
		}

		// Token: 0x06006A4D RID: 27213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005893")]
		[Address(RVA = "0x1EC6CA0", Offset = "0x1EC6DA1", VA = "0x1EC6CA0")]
		public WkiMove()
		{
		}

		// Token: 0x0401725D RID: 94813
		[Token(Token = "0x4013E6A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 PosOffset;

		// Token: 0x0401725E RID: 94814
		[Token(Token = "0x4013E6B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 _velocity;

		// Token: 0x0401725F RID: 94815
		[Token(Token = "0x4013E6C")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 localVelocity;

		// Token: 0x04017260 RID: 94816
		[Token(Token = "0x4013E6D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector3 _gravity;

		// Token: 0x04017261 RID: 94817
		[Token(Token = "0x4013E6E")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180BB0", Offset = "0x180CB1")]
		private Vector3 <Velocity>k__BackingField;

		// Token: 0x04017262 RID: 94818
		[Token(Token = "0x4013E6F")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180BC0", Offset = "0x180CC1")]
		private Vector3 <Gravity>k__BackingField;
	}
}
