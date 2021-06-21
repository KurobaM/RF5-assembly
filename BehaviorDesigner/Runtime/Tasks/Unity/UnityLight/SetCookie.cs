using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x0200142B RID: 5163
	[Token(Token = "0x2000DF1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152B70", Offset = "0x152C71")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152B70", Offset = "0x152C71")]
	public class SetCookie : Action
	{
		// Token: 0x0600771B RID: 30491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CF")]
		[Address(RVA = "0x28E7FD0", Offset = "0x28E80D1", VA = "0x28E7FD0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x00029610 File Offset: 0x00027810
		[Token(Token = "0x60063D0")]
		[Address(RVA = "0x28E80D0", Offset = "0x28E81D1", VA = "0x28E80D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D1")]
		[Address(RVA = "0x28E81B0", Offset = "0x28E82B1", VA = "0x28E81B0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600771E RID: 30494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D2")]
		[Address(RVA = "0x28E81F0", Offset = "0x28E82F1", VA = "0x28E81F0")]
		public SetCookie()
		{
		}

		// Token: 0x0401B9FD RID: 113149
		[Token(Token = "0x40183FB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E980", Offset = "0x18EA81")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B9FE RID: 113150
		[Token(Token = "0x40183FC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E9C0", Offset = "0x18EAC1")]
		public Texture2D cookie;

		// Token: 0x0401B9FF RID: 113151
		[Token(Token = "0x40183FD")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401BA00 RID: 113152
		[Token(Token = "0x40183FE")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
