using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPhysics2D
{
	// Token: 0x020013D7 RID: 5079
	[Token(Token = "0x2000DA2")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150DD0", Offset = "0x150ED1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150DD0", Offset = "0x150ED1")]
	public class Raycast : Action
	{
		// Token: 0x060075F9 RID: 30201 RVA: 0x00028EA8 File Offset: 0x000270A8
		[Token(Token = "0x60062AD")]
		[Address(RVA = "0x298D3F0", Offset = "0x298D4F1", VA = "0x298D3F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075FA RID: 30202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062AE")]
		[Address(RVA = "0x298D7A0", Offset = "0x298D8A1", VA = "0x298D7A0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075FB RID: 30203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062AF")]
		[Address(RVA = "0x298D880", Offset = "0x298D981", VA = "0x298D880")]
		public Raycast()
		{
		}

		// Token: 0x0401B8B6 RID: 112822
		[Token(Token = "0x40182D7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B930", Offset = "0x18BA31")]
		public SharedGameObject originGameObject;

		// Token: 0x0401B8B7 RID: 112823
		[Token(Token = "0x40182D8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B970", Offset = "0x18BA71")]
		public SharedVector2 originPosition;

		// Token: 0x0401B8B8 RID: 112824
		[Token(Token = "0x40182D9")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B9B0", Offset = "0x18BAB1")]
		public SharedVector2 direction;

		// Token: 0x0401B8B9 RID: 112825
		[Token(Token = "0x40182DA")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B9F0", Offset = "0x18BAF1")]
		public SharedFloat distance;

		// Token: 0x0401B8BA RID: 112826
		[Token(Token = "0x40182DB")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BA30", Offset = "0x18BB31")]
		public LayerMask layerMask;

		// Token: 0x0401B8BB RID: 112827
		[Token(Token = "0x40182DC")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BA70", Offset = "0x18BB71")]
		public Space space;

		// Token: 0x0401B8BC RID: 112828
		[Token(Token = "0x40182DD")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18BAB0", Offset = "0x18BBB1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BAB0", Offset = "0x18BBB1")]
		public SharedGameObject storeHitObject;

		// Token: 0x0401B8BD RID: 112829
		[Token(Token = "0x40182DE")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18BB00", Offset = "0x18BC01")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BB00", Offset = "0x18BC01")]
		public SharedVector2 storeHitPoint;

		// Token: 0x0401B8BE RID: 112830
		[Token(Token = "0x40182DF")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18BB50", Offset = "0x18BC51")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BB50", Offset = "0x18BC51")]
		public SharedVector2 storeHitNormal;

		// Token: 0x0401B8BF RID: 112831
		[Token(Token = "0x40182E0")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18BBA0", Offset = "0x18BCA1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18BBA0", Offset = "0x18BCA1")]
		public SharedFloat storeHitDistance;
	}
}
