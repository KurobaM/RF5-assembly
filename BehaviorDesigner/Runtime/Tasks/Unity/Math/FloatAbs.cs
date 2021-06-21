using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.Math
{
	// Token: 0x0200140D RID: 5133
	[Token(Token = "0x2000DD7")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1521B0", Offset = "0x1522B1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1521B0", Offset = "0x1522B1")]
	public class FloatAbs : Action
	{
		// Token: 0x060076C6 RID: 30406 RVA: 0x000293A0 File Offset: 0x000275A0
		[Token(Token = "0x600637A")]
		[Address(RVA = "0x221CB00", Offset = "0x221CC01", VA = "0x221CB00", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060076C7 RID: 30407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600637B")]
		[Address(RVA = "0x221CBB0", Offset = "0x221CCB1", VA = "0x221CBB0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060076C8 RID: 30408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600637C")]
		[Address(RVA = "0x221CC70", Offset = "0x221CD71", VA = "0x221CC70")]
		public FloatAbs()
		{
		}

		// Token: 0x0401B990 RID: 113040
		[Token(Token = "0x40183AC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18D920", Offset = "0x18DA21")]
		public SharedFloat floatVariable;
	}
}
