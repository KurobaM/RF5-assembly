using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x02001306 RID: 4870
	[Token(Token = "0x2000CD3")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14BFE0", Offset = "0x14C0E1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14BFE0", Offset = "0x14C0E1")]
	public class GetMagnitude : Action
	{
		// Token: 0x06007323 RID: 29475 RVA: 0x00027B40 File Offset: 0x00025D40
		[Token(Token = "0x6005FD7")]
		[Address(RVA = "0x2449C90", Offset = "0x2449D91", VA = "0x2449C90", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007324 RID: 29476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD8")]
		[Address(RVA = "0x2449D30", Offset = "0x2449E31", VA = "0x2449D30", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007325 RID: 29477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD9")]
		[Address(RVA = "0x2449DD0", Offset = "0x2449ED1", VA = "0x2449DD0")]
		public GetMagnitude()
		{
		}

		// Token: 0x0401B60C RID: 112140
		[Token(Token = "0x4018035")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183E90", Offset = "0x183F91")]
		public SharedVector3 vector3Variable;

		// Token: 0x0401B60D RID: 112141
		[Token(Token = "0x4018036")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183ED0", Offset = "0x183FD1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x183ED0", Offset = "0x183FD1")]
		public SharedFloat storeResult;
	}
}
