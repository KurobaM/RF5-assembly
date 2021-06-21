using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x0200131B RID: 4891
	[Token(Token = "0x2000CE7")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C760", Offset = "0x14C861")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C760", Offset = "0x14C861")]
	public class GetUpVector : Action
	{
		// Token: 0x0600735F RID: 29535 RVA: 0x00027D20 File Offset: 0x00025F20
		[Token(Token = "0x6006013")]
		[Address(RVA = "0x29A0380", Offset = "0x29A0481", VA = "0x29A0380", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007360 RID: 29536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006014")]
		[Address(RVA = "0x29A0410", Offset = "0x29A0511", VA = "0x29A0410", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007361 RID: 29537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006015")]
		[Address(RVA = "0x29A0490", Offset = "0x29A0591", VA = "0x29A0490")]
		public GetUpVector()
		{
		}

		// Token: 0x0401B646 RID: 112198
		[Token(Token = "0x401806B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184D40", Offset = "0x184E41")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184D40", Offset = "0x184E41")]
		public SharedVector2 storeResult;
	}
}
