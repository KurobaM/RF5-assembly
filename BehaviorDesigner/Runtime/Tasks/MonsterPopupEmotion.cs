using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012C7 RID: 4807
	[Token(Token = "0x2000C94")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14A6C0", Offset = "0x14A7C1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14A6C0", Offset = "0x14A7C1")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14A6C0", Offset = "0x14A7C1")]
	public class MonsterPopupEmotion : Action
	{
		// Token: 0x060071E5 RID: 29157 RVA: 0x00027228 File Offset: 0x00025428
		[Token(Token = "0x6005E99")]
		[Address(RVA = "0x2215030", Offset = "0x2215131", VA = "0x2215030", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E9A")]
		[Address(RVA = "0x22150A0", Offset = "0x22151A1", VA = "0x22150A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060071E7 RID: 29159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E9B")]
		[Address(RVA = "0x22150B0", Offset = "0x22151B1", VA = "0x22150B0")]
		public MonsterPopupEmotion()
		{
		}

		// Token: 0x0401B52E RID: 111918
		[Token(Token = "0x4017F57")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181C20", Offset = "0x181D21")]
		public SharedMonsterBehaviorController SharedMonsterBehaviorController;
	}
}
