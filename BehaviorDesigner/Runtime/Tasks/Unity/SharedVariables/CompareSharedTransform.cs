using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables
{
	// Token: 0x02001368 RID: 4968
	[Token(Token = "0x2000D33")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14E3E0", Offset = "0x14E4E1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14E3E0", Offset = "0x14E4E1")]
	public class CompareSharedTransform : Conditional
	{
		// Token: 0x0600746D RID: 29805 RVA: 0x00028440 File Offset: 0x00026640
		[Token(Token = "0x6006121")]
		[Address(RVA = "0x2220B60", Offset = "0x2220C61", VA = "0x2220B60", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600746E RID: 29806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006122")]
		[Address(RVA = "0x2220D30", Offset = "0x2220E31", VA = "0x2220D30", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600746F RID: 29807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006123")]
		[Address(RVA = "0x2220D70", Offset = "0x2220E71", VA = "0x2220D70")]
		public CompareSharedTransform()
		{
		}

		// Token: 0x0401B747 RID: 112455
		[Token(Token = "0x4018168")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187950", Offset = "0x187A51")]
		public SharedTransform variable;

		// Token: 0x0401B748 RID: 112456
		[Token(Token = "0x4018169")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x187990", Offset = "0x187A91")]
		public SharedTransform compareTo;
	}
}
