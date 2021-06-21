using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x02001305 RID: 4869
	[Token(Token = "0x2000CD2")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14BF80", Offset = "0x14C081")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14BF80", Offset = "0x14C081")]
	public class GetForwardVector : Action
	{
		// Token: 0x06007320 RID: 29472 RVA: 0x00027B28 File Offset: 0x00025D28
		[Token(Token = "0x6005FD4")]
		[Address(RVA = "0x2449B70", Offset = "0x2449C71", VA = "0x2449B70", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007321 RID: 29473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD5")]
		[Address(RVA = "0x2449C00", Offset = "0x2449D01", VA = "0x2449C00", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007322 RID: 29474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD6")]
		[Address(RVA = "0x2449C80", Offset = "0x2449D81", VA = "0x2449C80")]
		public GetForwardVector()
		{
		}

		// Token: 0x0401B60B RID: 112139
		[Token(Token = "0x4018034")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183E40", Offset = "0x183F41")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x183E40", Offset = "0x183F41")]
		public SharedVector3 storeResult;
	}
}
