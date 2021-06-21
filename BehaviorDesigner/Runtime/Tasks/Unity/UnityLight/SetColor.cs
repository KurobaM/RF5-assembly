using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x0200142A RID: 5162
	[Token(Token = "0x2000DF0")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152B10", Offset = "0x152C11")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152B10", Offset = "0x152C11")]
	public class SetColor : Action
	{
		// Token: 0x06007717 RID: 30487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CB")]
		[Address(RVA = "0x28E7D80", Offset = "0x28E7E81", VA = "0x28E7D80", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x000295F8 File Offset: 0x000277F8
		[Token(Token = "0x60063CC")]
		[Address(RVA = "0x28E7E80", Offset = "0x28E7F81", VA = "0x28E7E80", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007719 RID: 30489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CD")]
		[Address(RVA = "0x28E7F70", Offset = "0x28E8071", VA = "0x28E7F70", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600771A RID: 30490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CE")]
		[Address(RVA = "0x28E7FC0", Offset = "0x28E80C1", VA = "0x28E7FC0")]
		public SetColor()
		{
		}

		// Token: 0x0401B9F9 RID: 113145
		[Token(Token = "0x40183F7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E900", Offset = "0x18EA01")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B9FA RID: 113146
		[Token(Token = "0x40183F8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E940", Offset = "0x18EA41")]
		public SharedColor color;

		// Token: 0x0401B9FB RID: 113147
		[Token(Token = "0x40183F9")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401B9FC RID: 113148
		[Token(Token = "0x40183FA")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
