using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012C9 RID: 4809
	[Token(Token = "0x2000C96")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14A750", Offset = "0x14A851")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14A750", Offset = "0x14A851")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14A750", Offset = "0x14A851")]
	public class MonsterUpdateAroundParameter : Action
	{
		// Token: 0x060071ED RID: 29165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EA1")]
		[Address(RVA = "0x2215520", Offset = "0x2215621", VA = "0x2215520", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x060071EE RID: 29166 RVA: 0x00027258 File Offset: 0x00025458
		[Token(Token = "0x6005EA2")]
		[Address(RVA = "0x22155F0", Offset = "0x22156F1", VA = "0x22155F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060071EF RID: 29167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EA3")]
		[Address(RVA = "0x2215790", Offset = "0x2215891", VA = "0x2215790", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060071F0 RID: 29168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EA4")]
		[Address(RVA = "0x22157A0", Offset = "0x22158A1", VA = "0x22157A0", Slot = "17")]
		public override void OnDrawGizmos()
		{
		}

		// Token: 0x060071F1 RID: 29169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EA5")]
		[Address(RVA = "0x22157B0", Offset = "0x22158B1", VA = "0x22157B0")]
		public MonsterUpdateAroundParameter()
		{
		}

		// Token: 0x0401B535 RID: 111925
		[Token(Token = "0x4017F5E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181C60", Offset = "0x181D61")]
		public SharedVector3List AroundPositionList;

		// Token: 0x0401B536 RID: 111926
		[Token(Token = "0x4017F5F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181CA0", Offset = "0x181DA1")]
		public SharedVector3 ReturnMovePosition;

		// Token: 0x0401B537 RID: 111927
		[Token(Token = "0x4017F60")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x181CE0", Offset = "0x181DE1")]
		public SharedInt Index;

		// Token: 0x0401B538 RID: 111928
		[Token(Token = "0x4017F61")]
		[FieldOffset(Offset = "0x68")]
		private AIInput AIInput;
	}
}
