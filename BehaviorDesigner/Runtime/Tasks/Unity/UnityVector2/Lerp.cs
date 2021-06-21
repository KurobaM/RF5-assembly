using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x0200131E RID: 4894
	[Token(Token = "0x2000CEA")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C880", Offset = "0x14C981")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C880", Offset = "0x14C981")]
	public class Lerp : Action
	{
		// Token: 0x06007368 RID: 29544 RVA: 0x00027D68 File Offset: 0x00025F68
		[Token(Token = "0x600601C")]
		[Address(RVA = "0x29A07A0", Offset = "0x29A08A1", VA = "0x29A07A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600601D")]
		[Address(RVA = "0x29A08C0", Offset = "0x29A09C1", VA = "0x29A08C0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600736A RID: 29546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600601E")]
		[Address(RVA = "0x29A09A0", Offset = "0x29A0AA1", VA = "0x29A09A0")]
		public Lerp()
		{
		}

		// Token: 0x0401B64C RID: 112204
		[Token(Token = "0x4018071")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184F00", Offset = "0x185001")]
		public SharedVector2 fromVector2;

		// Token: 0x0401B64D RID: 112205
		[Token(Token = "0x4018072")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184F40", Offset = "0x185041")]
		public SharedVector2 toVector2;

		// Token: 0x0401B64E RID: 112206
		[Token(Token = "0x4018073")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184F80", Offset = "0x185081")]
		public SharedFloat lerpAmount;

		// Token: 0x0401B64F RID: 112207
		[Token(Token = "0x4018074")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184FC0", Offset = "0x1850C1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184FC0", Offset = "0x1850C1")]
		public SharedVector2 storeResult;
	}
}
