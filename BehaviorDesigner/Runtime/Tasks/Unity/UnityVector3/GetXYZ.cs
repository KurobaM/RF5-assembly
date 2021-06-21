using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x0200130B RID: 4875
	[Token(Token = "0x2000CD8")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C1C0", Offset = "0x14C2C1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C1C0", Offset = "0x14C2C1")]
	public class GetXYZ : Action
	{
		// Token: 0x06007332 RID: 29490 RVA: 0x00027BB8 File Offset: 0x00025DB8
		[Token(Token = "0x6005FE6")]
		[Address(RVA = "0x244A310", Offset = "0x244A411", VA = "0x244A310", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007333 RID: 29491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE7")]
		[Address(RVA = "0x244A3F0", Offset = "0x244A4F1", VA = "0x244A3F0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007334 RID: 29492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE8")]
		[Address(RVA = "0x244A4D0", Offset = "0x244A5D1", VA = "0x244A4D0")]
		public GetXYZ()
		{
		}

		// Token: 0x0401B614 RID: 112148
		[Token(Token = "0x401803D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1840E0", Offset = "0x1841E1")]
		public SharedVector3 vector3Variable;

		// Token: 0x0401B615 RID: 112149
		[Token(Token = "0x401803E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184120", Offset = "0x184221")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184120", Offset = "0x184221")]
		public SharedFloat storeX;

		// Token: 0x0401B616 RID: 112150
		[Token(Token = "0x401803F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184170", Offset = "0x184271")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184170", Offset = "0x184271")]
		public SharedFloat storeY;

		// Token: 0x0401B617 RID: 112151
		[Token(Token = "0x4018040")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1841C0", Offset = "0x1842C1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1841C0", Offset = "0x1842C1")]
		public SharedFloat storeZ;
	}
}
