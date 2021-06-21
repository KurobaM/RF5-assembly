using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x02001318 RID: 4888
	[Token(Token = "0x2000CE4")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C640", Offset = "0x14C741")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C640", Offset = "0x14C741")]
	public class GetMagnitude : Action
	{
		// Token: 0x06007356 RID: 29526 RVA: 0x00027CD8 File Offset: 0x00025ED8
		[Token(Token = "0x600600A")]
		[Address(RVA = "0x299FFC0", Offset = "0x29A00C1", VA = "0x299FFC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007357 RID: 29527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600600B")]
		[Address(RVA = "0x29A0060", Offset = "0x29A0161", VA = "0x29A0060", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007358 RID: 29528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600600C")]
		[Address(RVA = "0x29A0100", Offset = "0x29A0201", VA = "0x29A0100")]
		public GetMagnitude()
		{
		}

		// Token: 0x0401B641 RID: 112193
		[Token(Token = "0x4018066")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184BD0", Offset = "0x184CD1")]
		public SharedVector2 vector2Variable;

		// Token: 0x0401B642 RID: 112194
		[Token(Token = "0x4018067")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184C10", Offset = "0x184D11")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184C10", Offset = "0x184D11")]
		public SharedFloat storeResult;
	}
}
