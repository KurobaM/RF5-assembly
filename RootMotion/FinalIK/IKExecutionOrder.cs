using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D18 RID: 3352
	[Token(Token = "0x20008A3")]
	public class IKExecutionOrder : MonoBehaviour
	{
		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x060055E2 RID: 21986 RVA: 0x0001C428 File Offset: 0x0001A628
		[Token(Token = "0x170008B3")]
		private bool animatePhysics
		{
			[Token(Token = "0x6004793")]
			[Address(RVA = "0x2C14EF0", Offset = "0x2C14FF1", VA = "0x2C14EF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004794")]
		[Address(RVA = "0x2C14FA0", Offset = "0x2C150A1", VA = "0x2C14FA0")]
		private void Start()
		{
		}

		// Token: 0x060055E4 RID: 21988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004795")]
		[Address(RVA = "0x2C15010", Offset = "0x2C15111", VA = "0x2C15010")]
		private void Update()
		{
		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004796")]
		[Address(RVA = "0x2C15150", Offset = "0x2C15251", VA = "0x2C15150")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060055E6 RID: 21990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004797")]
		[Address(RVA = "0x2C15210", Offset = "0x2C15311", VA = "0x2C15210")]
		private void LateUpdate()
		{
		}

		// Token: 0x060055E7 RID: 21991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004798")]
		[Address(RVA = "0x2C150C0", Offset = "0x2C151C1", VA = "0x2C150C0")]
		private void FixTransforms()
		{
		}

		// Token: 0x060055E8 RID: 21992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004799")]
		[Address(RVA = "0x2C15360", Offset = "0x2C15461", VA = "0x2C15360")]
		public IKExecutionOrder()
		{
		}

		// Token: 0x0400B50C RID: 46348
		[Token(Token = "0x4008804")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1797C0", Offset = "0x1798C1")]
		public IK[] IKComponents;

		// Token: 0x0400B50D RID: 46349
		[Token(Token = "0x4008805")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179800", Offset = "0x179901")]
		public Animator animator;

		// Token: 0x0400B50E RID: 46350
		[Token(Token = "0x4008806")]
		[FieldOffset(Offset = "0x28")]
		private bool fixedFrame;
	}
}
