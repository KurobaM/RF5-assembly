using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x02001308 RID: 4872
	[Token(Token = "0x2000CD5")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C0A0", Offset = "0x14C1A1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C0A0", Offset = "0x14C1A1")]
	public class GetSqrMagnitude : Action
	{
		// Token: 0x06007329 RID: 29481 RVA: 0x00027B70 File Offset: 0x00025D70
		[Token(Token = "0x6005FDD")]
		[Address(RVA = "0x2449F00", Offset = "0x244A001", VA = "0x2449F00", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600732A RID: 29482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FDE")]
		[Address(RVA = "0x2449FA0", Offset = "0x244A0A1", VA = "0x2449FA0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FDF")]
		[Address(RVA = "0x244A040", Offset = "0x244A141", VA = "0x244A040")]
		public GetSqrMagnitude()
		{
		}

		// Token: 0x0401B60F RID: 112143
		[Token(Token = "0x4018038")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183F70", Offset = "0x184071")]
		public SharedVector3 vector3Variable;

		// Token: 0x0401B610 RID: 112144
		[Token(Token = "0x4018039")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x183FB0", Offset = "0x1840B1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x183FB0", Offset = "0x1840B1")]
		public SharedFloat storeResult;
	}
}
