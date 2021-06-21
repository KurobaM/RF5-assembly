using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimator
{
	// Token: 0x020014B0 RID: 5296
	[Token(Token = "0x2000E76")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x155D50", Offset = "0x155E51")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x155D50", Offset = "0x155E51")]
	public class Play : Action
	{
		// Token: 0x0600790A RID: 30986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BE")]
		[Address(RVA = "0x28D6D50", Offset = "0x28D6E51", VA = "0x28D6D50", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600790B RID: 30987 RVA: 0x0002A2A0 File Offset: 0x000284A0
		[Token(Token = "0x60065BF")]
		[Address(RVA = "0x28D6E50", Offset = "0x28D6F51", VA = "0x28D6E50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600790C RID: 30988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C0")]
		[Address(RVA = "0x28D6F50", Offset = "0x28D7051", VA = "0x28D6F50", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600790D RID: 30989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C1")]
		[Address(RVA = "0x28D6FD0", Offset = "0x28D70D1", VA = "0x28D6FD0")]
		public Play()
		{
		}

		// Token: 0x0401BBCD RID: 113613
		[Token(Token = "0x40185CB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193190", Offset = "0x193291")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BBCE RID: 113614
		[Token(Token = "0x40185CC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1931D0", Offset = "0x1932D1")]
		public SharedString stateName;

		// Token: 0x0401BBCF RID: 113615
		[Token(Token = "0x40185CD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193210", Offset = "0x193311")]
		public int layer;

		// Token: 0x0401BBD0 RID: 113616
		[Token(Token = "0x40185CE")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x193250", Offset = "0x193351")]
		public float normalizedTime;

		// Token: 0x0401BBD1 RID: 113617
		[Token(Token = "0x40185CF")]
		[FieldOffset(Offset = "0x68")]
		private Animator animator;

		// Token: 0x0401BBD2 RID: 113618
		[Token(Token = "0x40185D0")]
		[FieldOffset(Offset = "0x70")]
		private GameObject prevGameObject;
	}
}
