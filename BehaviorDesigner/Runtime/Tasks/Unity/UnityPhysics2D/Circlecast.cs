using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityPhysics2D
{
	// Token: 0x020013D5 RID: 5077
	[Token(Token = "0x2000DA0")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150D10", Offset = "0x150E11")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150D10", Offset = "0x150E11")]
	public class Circlecast : Action
	{
		// Token: 0x060075F3 RID: 30195 RVA: 0x00028E78 File Offset: 0x00027078
		[Token(Token = "0x60062A7")]
		[Address(RVA = "0x298CCB0", Offset = "0x298CDB1", VA = "0x298CCB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075F4 RID: 30196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A8")]
		[Address(RVA = "0x298D080", Offset = "0x298D181", VA = "0x298D080", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075F5 RID: 30197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A9")]
		[Address(RVA = "0x298D180", Offset = "0x298D281", VA = "0x298D180")]
		public Circlecast()
		{
		}

		// Token: 0x0401B8A8 RID: 112808
		[Token(Token = "0x40182C9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B570", Offset = "0x18B671")]
		public SharedGameObject originGameObject;

		// Token: 0x0401B8A9 RID: 112809
		[Token(Token = "0x40182CA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B5B0", Offset = "0x18B6B1")]
		public SharedVector2 originPosition;

		// Token: 0x0401B8AA RID: 112810
		[Token(Token = "0x40182CB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B5F0", Offset = "0x18B6F1")]
		public SharedFloat radius;

		// Token: 0x0401B8AB RID: 112811
		[Token(Token = "0x40182CC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B630", Offset = "0x18B731")]
		public SharedVector2 direction;

		// Token: 0x0401B8AC RID: 112812
		[Token(Token = "0x40182CD")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B670", Offset = "0x18B771")]
		public SharedFloat distance;

		// Token: 0x0401B8AD RID: 112813
		[Token(Token = "0x40182CE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B6B0", Offset = "0x18B7B1")]
		public LayerMask layerMask;

		// Token: 0x0401B8AE RID: 112814
		[Token(Token = "0x40182CF")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B6F0", Offset = "0x18B7F1")]
		public Space space;

		// Token: 0x0401B8AF RID: 112815
		[Token(Token = "0x40182D0")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18B730", Offset = "0x18B831")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B730", Offset = "0x18B831")]
		public SharedGameObject storeHitObject;

		// Token: 0x0401B8B0 RID: 112816
		[Token(Token = "0x40182D1")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18B780", Offset = "0x18B881")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B780", Offset = "0x18B881")]
		public SharedVector2 storeHitPoint;

		// Token: 0x0401B8B1 RID: 112817
		[Token(Token = "0x40182D2")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18B7D0", Offset = "0x18B8D1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B7D0", Offset = "0x18B8D1")]
		public SharedVector2 storeHitNormal;

		// Token: 0x0401B8B2 RID: 112818
		[Token(Token = "0x40182D3")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "SharedRequiredAttribute", RVA = "0x18B820", Offset = "0x18B921")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18B820", Offset = "0x18B921")]
		public SharedFloat storeHitDistance;
	}
}
