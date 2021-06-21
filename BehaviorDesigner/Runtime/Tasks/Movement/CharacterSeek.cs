using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	// Token: 0x020014DB RID: 5339
	[Token(Token = "0x2000E9E")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x156CA0", Offset = "0x156DA1")]
	public class CharacterSeek : Action
	{
		// Token: 0x060079B7 RID: 31159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006659")]
		[Address(RVA = "0x22157C0", Offset = "0x22158C1", VA = "0x22157C0", Slot = "4")]
		public override void OnAwake()
		{
		}

		// Token: 0x060079B8 RID: 31160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600665A")]
		[Address(RVA = "0x22158B0", Offset = "0x22159B1", VA = "0x22158B0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x060079B9 RID: 31161 RVA: 0x0002A6C0 File Offset: 0x000288C0
		[Token(Token = "0x600665B")]
		[Address(RVA = "0x2215DC0", Offset = "0x2215EC1", VA = "0x2215DC0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060079BA RID: 31162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600665C")]
		[Address(RVA = "0x2216160", Offset = "0x2216261", VA = "0x2216160", Slot = "9")]
		public override void OnEnd()
		{
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x0002A6D8 File Offset: 0x000288D8
		[Token(Token = "0x600665D")]
		[Address(RVA = "0x2216230", Offset = "0x2216331", VA = "0x2216230")]
		private bool IsUpdatePath()
		{
			return default(bool);
		}

		// Token: 0x060079BC RID: 31164 RVA: 0x0002A6F0 File Offset: 0x000288F0
		[Token(Token = "0x600665E")]
		[Address(RVA = "0x2215AB0", Offset = "0x2215BB1", VA = "0x2215AB0")]
		private Vector3 Target()
		{
			return default(Vector3);
		}

		// Token: 0x060079BD RID: 31165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600665F")]
		[Address(RVA = "0x22162E0", Offset = "0x22163E1", VA = "0x22162E0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060079BE RID: 31166 RVA: 0x0002A708 File Offset: 0x00028908
		[Token(Token = "0x6006660")]
		[Address(RVA = "0x2216030", Offset = "0x2216131", VA = "0x2216030")]
		private bool HasArrived()
		{
			return default(bool);
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006661")]
		[Address(RVA = "0x2216420", Offset = "0x2216521", VA = "0x2216420")]
		public CharacterSeek()
		{
		}

		// Token: 0x0401BC75 RID: 113781
		[Token(Token = "0x4018667")]
		private const float CalcPathSqrRange = 90f;

		// Token: 0x0401BC76 RID: 113782
		[Token(Token = "0x4018668")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<Vector3> CheckTargetAroundPointList;

		// Token: 0x0401BC77 RID: 113783
		[Token(Token = "0x4018669")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194980", Offset = "0x194A81")]
		public SharedGameObject target;

		// Token: 0x0401BC78 RID: 113784
		[Token(Token = "0x401866A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1949C0", Offset = "0x194AC1")]
		public SharedVector3 targetPosition;

		// Token: 0x0401BC79 RID: 113785
		[Token(Token = "0x401866B")]
		[FieldOffset(Offset = "0x68")]
		public SharedBool IsRotate;

		// Token: 0x0401BC7A RID: 113786
		[Token(Token = "0x401866C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x194A00", Offset = "0x194B01")]
		public SharedFloat MoveSpeedScale;

		// Token: 0x0401BC7B RID: 113787
		[Token(Token = "0x401866D")]
		[FieldOffset(Offset = "0x78")]
		public SharedFloat ArriveDistance;

		// Token: 0x0401BC7C RID: 113788
		[Token(Token = "0x401866E")]
		[FieldOffset(Offset = "0x80")]
		public bool IsClearVelocity;

		// Token: 0x0401BC7D RID: 113789
		[Token(Token = "0x401866F")]
		[FieldOffset(Offset = "0x88")]
		private AIInput AIInput;

		// Token: 0x0401BC7E RID: 113790
		[Token(Token = "0x4018670")]
		[FieldOffset(Offset = "0x0")]
		public static string MoveSpeedScaleKey;

		// Token: 0x0401BC7F RID: 113791
		[Token(Token = "0x4018671")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 LatestSteeringTarget;

		// Token: 0x0401BC80 RID: 113792
		[Token(Token = "0x4018672")]
		[FieldOffset(Offset = "0x9C")]
		private NavMeshHit TargetNavMeshHit;

		// Token: 0x0401BC81 RID: 113793
		[Token(Token = "0x4018673")]
		[FieldOffset(Offset = "0xC0")]
		private NavMeshPath CalcNavMeshPath;
	}
}
