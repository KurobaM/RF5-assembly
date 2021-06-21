using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPhysics2D
{
	// Token: 0x020013D6 RID: 5078
	[Token(Token = "0x2000DA1")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150D70", Offset = "0x150E71")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150D70", Offset = "0x150E71")]
	public class Linecast : Action
	{
		// Token: 0x060075F6 RID: 30198 RVA: 0x00028E90 File Offset: 0x00027090
		[Token(Token = "0x60062AA")]
		[Address(RVA = "0x298D1E0", Offset = "0x298D2E1", VA = "0x298D1E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075F7 RID: 30199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062AB")]
		[Address(RVA = "0x298D300", Offset = "0x298D401", VA = "0x298D300", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075F8 RID: 30200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062AC")]
		[Address(RVA = "0x298D3B0", Offset = "0x298D4B1", VA = "0x298D3B0")]
		public Linecast()
		{
		}

		// Token: 0x0401B8B3 RID: 112819
		[Token(Token = "0x40182D4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B870", Offset = "0x18B971")]
		public SharedVector2 startPosition;

		// Token: 0x0401B8B4 RID: 112820
		[Token(Token = "0x40182D5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B8B0", Offset = "0x18B9B1")]
		public SharedVector2 endPosition;

		// Token: 0x0401B8B5 RID: 112821
		[Token(Token = "0x40182D6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B8F0", Offset = "0x18B9F1")]
		public LayerMask layerMask;
	}
}
