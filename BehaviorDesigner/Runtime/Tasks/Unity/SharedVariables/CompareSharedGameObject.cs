using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001360 RID: 4960
	[Token(Token = "0x2000D2B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E0E0", Offset = "0x14E1E1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E0E0", Offset = "0x14E1E1")]
	public class CompareSharedGameObject : Conditional
	{
		// Token: 0x06007455 RID: 29781 RVA: 0x00028380 File Offset: 0x00026580
		[Token(Token = "0x6006109")]
		[Address(RVA = "0x221FA90", Offset = "0x221FB91", VA = "0x221FA90", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007456 RID: 29782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600610A")]
		[Address(RVA = "0x221FC60", Offset = "0x221FD61", VA = "0x221FC60", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007457 RID: 29783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600610B")]
		[Address(RVA = "0x221FCA0", Offset = "0x221FDA1", VA = "0x221FCA0")]
		public CompareSharedGameObject()
		{
		}

		// Token: 0x0401B737 RID: 112439
		[Token(Token = "0x4018158")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187550", Offset = "0x187651")]
		public SharedGameObject variable;

		// Token: 0x0401B738 RID: 112440
		[Token(Token = "0x4018159")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187590", Offset = "0x187691")]
		public SharedGameObject compareTo;
	}
}
