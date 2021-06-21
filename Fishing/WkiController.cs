using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Fishing
{
	// Token: 0x02001072 RID: 4210
	[Token(Token = "0x2000AAB")]
	public class WkiController : MonoBehaviour
	{
		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06006A38 RID: 27192 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006A39 RID: 27193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A9B")]
		public Character Owner
		{
			[Token(Token = "0x600587E")]
			[Address(RVA = "0x1EC5820", Offset = "0x1EC5921", VA = "0x1EC5820")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD790", Offset = "0x1AD891")]
			get
			{
				return null;
			}
			[Token(Token = "0x600587F")]
			[Address(RVA = "0x1EC5830", Offset = "0x1EC5931", VA = "0x1EC5830")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD7A0", Offset = "0x1AD8A1")]
			set
			{
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06006A3A RID: 27194 RVA: 0x000244E0 File Offset: 0x000226E0
		[Token(Token = "0x17000A9C")]
		public bool IsHit
		{
			[Token(Token = "0x6005880")]
			[Address(RVA = "0x1EC5840", Offset = "0x1EC5941", VA = "0x1EC5840")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06006A3B RID: 27195 RVA: 0x000244F8 File Offset: 0x000226F8
		// (set) Token: 0x06006A3C RID: 27196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A9D")]
		public bool IsHitWater
		{
			[Token(Token = "0x6005881")]
			[Address(RVA = "0x1EC5850", Offset = "0x1EC5951", VA = "0x1EC5850")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD7B0", Offset = "0x1AD8B1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005882")]
			[Address(RVA = "0x1EC5860", Offset = "0x1EC5961", VA = "0x1EC5860")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD7C0", Offset = "0x1AD8C1")]
			protected set
			{
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06006A3D RID: 27197 RVA: 0x00024510 File Offset: 0x00022710
		// (set) Token: 0x06006A3E RID: 27198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A9E")]
		public bool IsHitGround
		{
			[Token(Token = "0x6005883")]
			[Address(RVA = "0x1EC5870", Offset = "0x1EC5971", VA = "0x1EC5870")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD7D0", Offset = "0x1AD8D1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005884")]
			[Address(RVA = "0x1EC5880", Offset = "0x1EC5981", VA = "0x1EC5880")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD7E0", Offset = "0x1AD8E1")]
			protected set
			{
			}
		}

		// Token: 0x06006A3F RID: 27199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005885")]
		[Address(RVA = "0x1EC5890", Offset = "0x1EC5991", VA = "0x1EC5890")]
		public void Reset(Character chara, Vector3 pos, Quaternion dir)
		{
		}

		// Token: 0x06006A40 RID: 27200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005886")]
		[Address(RVA = "0x1EC5C70", Offset = "0x1EC5D71", VA = "0x1EC5C70")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06006A41 RID: 27201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005887")]
		[Address(RVA = "0x1EC5FB0", Offset = "0x1EC60B1", VA = "0x1EC5FB0")]
		public void OnHit(Collider hit, Vector3 point)
		{
		}

		// Token: 0x06006A42 RID: 27202 RVA: 0x00024528 File Offset: 0x00022728
		[Token(Token = "0x6005888")]
		[Address(RVA = "0x1EC6160", Offset = "0x1EC6261", VA = "0x1EC6160")]
		public bool OnHitWater(Collider hit, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x00024540 File Offset: 0x00022740
		[Token(Token = "0x6005889")]
		[Address(RVA = "0x1EC6770", Offset = "0x1EC6871", VA = "0x1EC6770")]
		public bool OnHitChara(Character chara, Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06006A44 RID: 27204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600588A")]
		[Address(RVA = "0x1EC6A20", Offset = "0x1EC6B21", VA = "0x1EC6A20")]
		public WkiController()
		{
		}

		// Token: 0x04017255 RID: 94805
		[Token(Token = "0x4013E62")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WkiMove m_Move;

		// Token: 0x04017256 RID: 94806
		[Token(Token = "0x4013E63")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WkiSphereCollider m_Collider;

		// Token: 0x04017257 RID: 94807
		[Token(Token = "0x4013E64")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x180B10", Offset = "0x180C11")]
		private float heightLlimit;

		// Token: 0x04017258 RID: 94808
		[Token(Token = "0x4013E65")]
		[FieldOffset(Offset = "0x2C")]
		private float startHeight;

		// Token: 0x04017259 RID: 94809
		[Token(Token = "0x4013E66")]
		[FieldOffset(Offset = "0x30")]
		public DamageInfo m_DamageInfo;

		// Token: 0x0401725A RID: 94810
		[Token(Token = "0x4013E67")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180B50", Offset = "0x180C51")]
		private Character <Owner>k__BackingField;

		// Token: 0x0401725B RID: 94811
		[Token(Token = "0x4013E68")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180B60", Offset = "0x180C61")]
		private bool <IsHitWater>k__BackingField;

		// Token: 0x0401725C RID: 94812
		[Token(Token = "0x4013E69")]
		[FieldOffset(Offset = "0xB9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180B70", Offset = "0x180C71")]
		private bool <IsHitGround>k__BackingField;
	}
}
