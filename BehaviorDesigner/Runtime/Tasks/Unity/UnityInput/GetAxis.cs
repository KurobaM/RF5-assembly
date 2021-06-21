using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityInput
{
	// Token: 0x02001438 RID: 5176
	[Token(Token = "0x2000DFE")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153050", Offset = "0x153151")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153050", Offset = "0x153151")]
	public class GetAxis : Action
	{
		// Token: 0x0600774C RID: 30540 RVA: 0x00029748 File Offset: 0x00027948
		[Token(Token = "0x6006400")]
		[Address(RVA = "0x28E5FF0", Offset = "0x28E60F1", VA = "0x28E5FF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006401")]
		[Address(RVA = "0x28E60B0", Offset = "0x28E61B1", VA = "0x28E60B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006402")]
		[Address(RVA = "0x28E6150", Offset = "0x28E6251", VA = "0x28E6150")]
		public GetAxis()
		{
		}

		// Token: 0x0401BA2A RID: 113194
		[Token(Token = "0x4018428")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EFE0", Offset = "0x18F0E1")]
		public SharedString axisName;

		// Token: 0x0401BA2B RID: 113195
		[Token(Token = "0x4018429")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F020", Offset = "0x18F121")]
		public SharedFloat multiplier;

		// Token: 0x0401BA2C RID: 113196
		[Token(Token = "0x401842A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18F060", Offset = "0x18F161")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F060", Offset = "0x18F161")]
		public SharedFloat storeResult;
	}
}
