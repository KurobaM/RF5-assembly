using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x0200135D RID: 4957
	[Token(Token = "0x2000D28")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DFC0", Offset = "0x14E0C1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DFC0", Offset = "0x14E0C1")]
	public class CompareSharedBool : Conditional
	{
		// Token: 0x0600744C RID: 29772 RVA: 0x00028338 File Offset: 0x00026538
		[Token(Token = "0x6006100")]
		[Address(RVA = "0x221F490", Offset = "0x221F591", VA = "0x221F490", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600744D RID: 29773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006101")]
		[Address(RVA = "0x221F530", Offset = "0x221F631", VA = "0x221F530", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600744E RID: 29774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006102")]
		[Address(RVA = "0x221F660", Offset = "0x221F761", VA = "0x221F660")]
		public CompareSharedBool()
		{
		}

		// Token: 0x0401B731 RID: 112433
		[Token(Token = "0x4018152")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1873D0", Offset = "0x1874D1")]
		public SharedBool variable;

		// Token: 0x0401B732 RID: 112434
		[Token(Token = "0x4018153")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187410", Offset = "0x187511")]
		public SharedBool compareTo;
	}
}
