using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	// Token: 0x0200144D RID: 5197
	[Token(Token = "0x2000E13")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153830", Offset = "0x153931")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153830", Offset = "0x153931")]
	public class GetComponent : Action
	{
		// Token: 0x0600778B RID: 30603 RVA: 0x00029940 File Offset: 0x00027B40
		[Token(Token = "0x600643F")]
		[Address(RVA = "0x28E55E0", Offset = "0x28E56E1", VA = "0x28E55E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600778C RID: 30604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006440")]
		[Address(RVA = "0x28E56B0", Offset = "0x28E57B1", VA = "0x28E56B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600778D RID: 30605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006441")]
		[Address(RVA = "0x28E5750", Offset = "0x28E5851", VA = "0x28E5750")]
		public GetComponent()
		{
		}

		// Token: 0x0401BA4D RID: 113229
		[Token(Token = "0x401844B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F930", Offset = "0x18FA31")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA4E RID: 113230
		[Token(Token = "0x401844C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F970", Offset = "0x18FA71")]
		public SharedString type;

		// Token: 0x0401BA4F RID: 113231
		[Token(Token = "0x401844D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F9B0", Offset = "0x18FAB1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18F9B0", Offset = "0x18FAB1")]
		public SharedObject storeValue;
	}
}
