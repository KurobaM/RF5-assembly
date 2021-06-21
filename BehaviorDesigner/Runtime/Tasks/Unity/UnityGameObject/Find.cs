using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	// Token: 0x0200144A RID: 5194
	[Token(Token = "0x2000E10")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153710", Offset = "0x153811")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153710", Offset = "0x153811")]
	public class Find : Action
	{
		// Token: 0x06007782 RID: 30594 RVA: 0x000298F8 File Offset: 0x00027AF8
		[Token(Token = "0x6006436")]
		[Address(RVA = "0x28E5120", Offset = "0x28E5221", VA = "0x28E5120", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007783 RID: 30595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006437")]
		[Address(RVA = "0x28E5200", Offset = "0x28E5301", VA = "0x28E5200", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007784 RID: 30596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006438")]
		[Address(RVA = "0x28E5240", Offset = "0x28E5341", VA = "0x28E5240")]
		public Find()
		{
		}

		// Token: 0x0401BA46 RID: 113222
		[Token(Token = "0x4018444")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F740", Offset = "0x18F841")]
		public SharedString gameObjectName;

		// Token: 0x0401BA47 RID: 113223
		[Token(Token = "0x4018445")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F780", Offset = "0x18F881")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18F780", Offset = "0x18F881")]
		public SharedGameObject storeValue;
	}
}
