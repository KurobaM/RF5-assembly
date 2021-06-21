using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x0200130A RID: 4874
	[Token(Token = "0x2000CD7")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C160", Offset = "0x14C261")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C160", Offset = "0x14C261")]
	public class GetVector2 : Action
	{
		// Token: 0x0600732F RID: 29487 RVA: 0x00027BA0 File Offset: 0x00025DA0
		[Token(Token = "0x6005FE3")]
		[Address(RVA = "0x244A170", Offset = "0x244A271", VA = "0x244A170", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007330 RID: 29488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE4")]
		[Address(RVA = "0x244A240", Offset = "0x244A341", VA = "0x244A240", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE5")]
		[Address(RVA = "0x244A300", Offset = "0x244A401", VA = "0x244A300")]
		public GetVector2()
		{
		}

		// Token: 0x0401B612 RID: 112146
		[Token(Token = "0x401803B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184050", Offset = "0x184151")]
		public SharedVector3 vector3Variable;

		// Token: 0x0401B613 RID: 112147
		[Token(Token = "0x401803C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184090", Offset = "0x184191")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x184090", Offset = "0x184191")]
		public SharedVector2 storeResult;
	}
}
