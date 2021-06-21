using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001380 RID: 4992
	[Token(Token = "0x2000D4B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14ECE0", Offset = "0x14EDE1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14ECE0", Offset = "0x14EDE1")]
	public class SharedTransformsToTransformList : Action
	{
		// Token: 0x060074B6 RID: 29878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616A")]
		[Address(RVA = "0x28D1480", Offset = "0x28D1581", VA = "0x28D1480", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x060074B7 RID: 29879 RVA: 0x00028680 File Offset: 0x00026880
		[Token(Token = "0x600616B")]
		[Address(RVA = "0x28D1510", Offset = "0x28D1611", VA = "0x28D1510", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060074B8 RID: 29880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616C")]
		[Address(RVA = "0x28D1640", Offset = "0x28D1741", VA = "0x28D1640", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060074B9 RID: 29881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616D")]
		[Address(RVA = "0x28D1680", Offset = "0x28D1781", VA = "0x28D1680")]
		public SharedTransformsToTransformList()
		{
		}

		// Token: 0x0401B778 RID: 112504
		[Token(Token = "0x4018199")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1886C0", Offset = "0x1887C1")]
		public SharedTransform[] transforms;

		// Token: 0x0401B779 RID: 112505
		[Token(Token = "0x401819A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x188700", Offset = "0x188801")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x188700", Offset = "0x188801")]
		public SharedTransformList storedTransformList;
	}
}
