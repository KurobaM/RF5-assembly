using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityRenderer
{
	// Token: 0x020013BE RID: 5054
	[Token(Token = "0x2000D89")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150470", Offset = "0x150571")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150470", Offset = "0x150571")]
	public class IsVisible : Conditional
	{
		// Token: 0x060075AE RID: 30126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006262")]
		[Address(RVA = "0x298F670", Offset = "0x298F771", VA = "0x298F670", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060075AF RID: 30127 RVA: 0x00028C50 File Offset: 0x00026E50
		[Token(Token = "0x6006263")]
		[Address(RVA = "0x298F770", Offset = "0x298F871", VA = "0x298F770", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075B0 RID: 30128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006264")]
		[Address(RVA = "0x298F850", Offset = "0x298F951", VA = "0x298F850", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075B1 RID: 30129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006265")]
		[Address(RVA = "0x298F860", Offset = "0x298F961", VA = "0x298F860")]
		public IsVisible()
		{
		}

		// Token: 0x0401B870 RID: 112752
		[Token(Token = "0x4018291")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A790", Offset = "0x18A891")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B871 RID: 112753
		[Token(Token = "0x4018292")]
		[FieldOffset(Offset = "0x58")]
		private Renderer renderer;

		// Token: 0x0401B872 RID: 112754
		[Token(Token = "0x4018293")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
