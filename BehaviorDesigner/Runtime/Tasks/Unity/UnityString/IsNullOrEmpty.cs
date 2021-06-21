using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityString
{
	// Token: 0x02001356 RID: 4950
	[Token(Token = "0x2000D21")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DD20", Offset = "0x14DE21")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DD20", Offset = "0x14DE21")]
	public class IsNullOrEmpty : Conditional
	{
		// Token: 0x06007433 RID: 29747 RVA: 0x00028290 File Offset: 0x00026490
		[Token(Token = "0x60060E7")]
		[Address(RVA = "0x299A0B0", Offset = "0x299A1B1", VA = "0x299A0B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007434 RID: 29748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E8")]
		[Address(RVA = "0x299A120", Offset = "0x299A221", VA = "0x299A120", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007435 RID: 29749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E9")]
		[Address(RVA = "0x299A180", Offset = "0x299A281", VA = "0x299A180")]
		public IsNullOrEmpty()
		{
		}

		// Token: 0x0401B71A RID: 112410
		[Token(Token = "0x401813B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186FD0", Offset = "0x1870D1")]
		public SharedString targetString;
	}
}
