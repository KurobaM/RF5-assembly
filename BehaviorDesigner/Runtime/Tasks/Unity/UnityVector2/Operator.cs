using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2
{
	// Token: 0x02001322 RID: 4898
	[Token(Token = "0x2000CEE")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14CA00", Offset = "0x14CB01")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14CA00", Offset = "0x14CB01")]
	public class Operator : Action
	{
		// Token: 0x06007374 RID: 29556 RVA: 0x00027DC8 File Offset: 0x00025FC8
		[Token(Token = "0x6006028")]
		[Address(RVA = "0x2448E50", Offset = "0x2448F51", VA = "0x2448E50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007375 RID: 29557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006029")]
		[Address(RVA = "0x2449050", Offset = "0x2449151", VA = "0x2449050", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007376 RID: 29558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602A")]
		[Address(RVA = "0x2449110", Offset = "0x2449211", VA = "0x2449110")]
		public Operator()
		{
		}

		// Token: 0x0401B659 RID: 112217
		[Token(Token = "0x401807E")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185280", Offset = "0x185381")]
		public Operator.Operation operation;

		// Token: 0x0401B65A RID: 112218
		[Token(Token = "0x401807F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1852C0", Offset = "0x1853C1")]
		public SharedVector2 firstVector2;

		// Token: 0x0401B65B RID: 112219
		[Token(Token = "0x4018080")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185300", Offset = "0x185401")]
		public SharedVector2 secondVector2;

		// Token: 0x0401B65C RID: 112220
		[Token(Token = "0x4018081")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x185340", Offset = "0x185441")]
		public SharedVector2 storeResult;

		// Token: 0x02001323 RID: 4899
		[Token(Token = "0x20015A0")]
		public enum Operation
		{
			// Token: 0x0401B65E RID: 112222
			[Token(Token = "0x401C1E8")]
			Add,
			// Token: 0x0401B65F RID: 112223
			[Token(Token = "0x401C1E9")]
			Subtract,
			// Token: 0x0401B660 RID: 112224
			[Token(Token = "0x401C1EA")]
			Scale
		}
	}
}
