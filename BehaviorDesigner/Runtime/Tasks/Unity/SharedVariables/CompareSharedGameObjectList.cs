using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001361 RID: 4961
	[Token(Token = "0x2000D2C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E140", Offset = "0x14E241")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E140", Offset = "0x14E241")]
	public class CompareSharedGameObjectList : Conditional
	{
		// Token: 0x06007458 RID: 29784 RVA: 0x00028398 File Offset: 0x00026598
		[Token(Token = "0x600610C")]
		[Address(RVA = "0x221FCB0", Offset = "0x221FDB1", VA = "0x221FCB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007459 RID: 29785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600610D")]
		[Address(RVA = "0x221FE80", Offset = "0x221FF81", VA = "0x221FE80", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600745A RID: 29786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600610E")]
		[Address(RVA = "0x221FEC0", Offset = "0x221FFC1", VA = "0x221FEC0")]
		public CompareSharedGameObjectList()
		{
		}

		// Token: 0x0401B739 RID: 112441
		[Token(Token = "0x401815A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1875D0", Offset = "0x1876D1")]
		public SharedGameObjectList variable;

		// Token: 0x0401B73A RID: 112442
		[Token(Token = "0x401815B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187610", Offset = "0x187711")]
		public SharedGameObjectList compareTo;
	}
}
