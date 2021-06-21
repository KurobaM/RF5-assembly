using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001365 RID: 4965
	[Token(Token = "0x2000D30")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E2C0", Offset = "0x14E3C1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E2C0", Offset = "0x14E3C1")]
	public class CompareSharedQuaternion : Conditional
	{
		// Token: 0x06007464 RID: 29796 RVA: 0x000283F8 File Offset: 0x000265F8
		[Token(Token = "0x6006118")]
		[Address(RVA = "0x22204F0", Offset = "0x22205F1", VA = "0x22204F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007465 RID: 29797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006119")]
		[Address(RVA = "0x2220590", Offset = "0x2220691", VA = "0x2220590", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007466 RID: 29798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611A")]
		[Address(RVA = "0x2220740", Offset = "0x2220841", VA = "0x2220740")]
		public CompareSharedQuaternion()
		{
		}

		// Token: 0x0401B741 RID: 112449
		[Token(Token = "0x4018162")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1877D0", Offset = "0x1878D1")]
		public SharedQuaternion variable;

		// Token: 0x0401B742 RID: 112450
		[Token(Token = "0x4018163")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187810", Offset = "0x187911")]
		public SharedQuaternion compareTo;
	}
}
