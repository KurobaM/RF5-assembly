using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityAnimation
{
	// Token: 0x020014CC RID: 5324
	[Token(Token = "0x2000E8F")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1566B0", Offset = "0x1567B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1566B0", Offset = "0x1567B1")]
	public class SetWrapMode : Action
	{
		// Token: 0x06007986 RID: 31110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006628")]
		[Address(RVA = "0x28D4010", Offset = "0x28D4111", VA = "0x28D4010", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007987 RID: 31111 RVA: 0x0002A540 File Offset: 0x00028740
		[Token(Token = "0x6006629")]
		[Address(RVA = "0x28D4110", Offset = "0x28D4211", VA = "0x28D4110", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007988 RID: 31112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662A")]
		[Address(RVA = "0x28D41F0", Offset = "0x28D42F1", VA = "0x28D41F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007989 RID: 31113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600662B")]
		[Address(RVA = "0x28D4220", Offset = "0x28D4321", VA = "0x28D4220")]
		public SetWrapMode()
		{
		}

		// Token: 0x0401BC54 RID: 113748
		[Token(Token = "0x4018646")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1942E0", Offset = "0x1943E1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BC55 RID: 113749
		[Token(Token = "0x4018647")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194320", Offset = "0x194421")]
		public WrapMode wrapMode;

		// Token: 0x0401BC56 RID: 113750
		[Token(Token = "0x4018648")]
		[FieldOffset(Offset = "0x60")]
		private Animation animation;

		// Token: 0x0401BC57 RID: 113751
		[Token(Token = "0x4018649")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
