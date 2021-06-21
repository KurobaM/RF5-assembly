using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	// Token: 0x02001448 RID: 5192
	[Token(Token = "0x2000E0E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153650", Offset = "0x153751")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153650", Offset = "0x153751")]
	public class Destroy : Action
	{
		// Token: 0x0600777C RID: 30588 RVA: 0x000298C8 File Offset: 0x00027AC8
		[Token(Token = "0x6006430")]
		[Address(RVA = "0x28E4F40", Offset = "0x28E5041", VA = "0x28E4F40", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600777D RID: 30589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006431")]
		[Address(RVA = "0x28E5020", Offset = "0x28E5121", VA = "0x28E5020", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600777E RID: 30590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006432")]
		[Address(RVA = "0x28E5050", Offset = "0x28E5151", VA = "0x28E5050")]
		public Destroy()
		{
		}

		// Token: 0x0401BA43 RID: 113219
		[Token(Token = "0x4018441")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F680", Offset = "0x18F781")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA44 RID: 113220
		[Token(Token = "0x4018442")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F6C0", Offset = "0x18F7C1")]
		public float time;
	}
}
