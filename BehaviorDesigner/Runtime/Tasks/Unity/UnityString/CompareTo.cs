using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityString
{
	// Token: 0x02001351 RID: 4945
	[Token(Token = "0x2000D1C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14DB40", Offset = "0x14DC41")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14DB40", Offset = "0x14DC41")]
	public class CompareTo : Action
	{
		// Token: 0x06007423 RID: 29731 RVA: 0x00028218 File Offset: 0x00026418
		[Token(Token = "0x60060D7")]
		[Address(RVA = "0x29997B0", Offset = "0x29998B1", VA = "0x29997B0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007424 RID: 29732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D8")]
		[Address(RVA = "0x2999860", Offset = "0x2999961", VA = "0x2999860", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007425 RID: 29733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D9")]
		[Address(RVA = "0x2999900", Offset = "0x2999A01", VA = "0x2999900")]
		public CompareTo()
		{
		}

		// Token: 0x0401B70B RID: 112395
		[Token(Token = "0x401812C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186C00", Offset = "0x186D01")]
		public SharedString firstString;

		// Token: 0x0401B70C RID: 112396
		[Token(Token = "0x401812D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186C40", Offset = "0x186D41")]
		public SharedString secondString;

		// Token: 0x0401B70D RID: 112397
		[Token(Token = "0x401812E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x186C80", Offset = "0x186D81")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x186C80", Offset = "0x186D81")]
		public SharedInt storeResult;
	}
}
