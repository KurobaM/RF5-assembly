using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000CA2 RID: 3234
	[Token(Token = "0x2000848")]
	public class SolverManager : MonoBehaviour
	{
		// Token: 0x06005358 RID: 21336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004576")]
		[Address(RVA = "0x27D9540", Offset = "0x27D9641", VA = "0x27D9540")]
		public void Disable()
		{
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004577")]
		[Address(RVA = "0x27D95E0", Offset = "0x27D96E1", VA = "0x27D95E0", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		// Token: 0x0600535A RID: 21338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004578")]
		[Address(RVA = "0x27D95F0", Offset = "0x27D96F1", VA = "0x27D95F0", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004579")]
		[Address(RVA = "0x27D9600", Offset = "0x27D9701", VA = "0x27D9600", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457A")]
		[Address(RVA = "0x27D9610", Offset = "0x27D9711", VA = "0x27D9610")]
		private void OnDisable()
		{
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457B")]
		[Address(RVA = "0x27D96E0", Offset = "0x27D97E1", VA = "0x27D96E0")]
		private void Start()
		{
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x0600535E RID: 21342 RVA: 0x0001BA08 File Offset: 0x00019C08
		[Token(Token = "0x17000893")]
		private bool animatePhysics
		{
			[Token(Token = "0x600457C")]
			[Address(RVA = "0x27D9740", Offset = "0x27D9841", VA = "0x27D9740")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457D")]
		[Address(RVA = "0x27D9680", Offset = "0x27D9781", VA = "0x27D9680")]
		private void Initiate()
		{
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457E")]
		[Address(RVA = "0x27D9A40", Offset = "0x27D9B41", VA = "0x27D9A40")]
		private void Update()
		{
		}

		// Token: 0x06005361 RID: 21345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457F")]
		[Address(RVA = "0x27D9840", Offset = "0x27D9941", VA = "0x27D9840")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06005362 RID: 21346 RVA: 0x0001BA20 File Offset: 0x00019C20
		[Token(Token = "0x17000894")]
		private bool isAnimated
		{
			[Token(Token = "0x6004580")]
			[Address(RVA = "0x27D9A90", Offset = "0x27D9B91", VA = "0x27D9A90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004581")]
		[Address(RVA = "0x27D9B50", Offset = "0x27D9C51", VA = "0x27D9B50")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004582")]
		[Address(RVA = "0x27D9BB0", Offset = "0x27D9CB1", VA = "0x27D9BB0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004583")]
		[Address(RVA = "0x27D9C10", Offset = "0x27D9D11", VA = "0x27D9C10")]
		public void UpdateSolverExternal()
		{
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004584")]
		[Address(RVA = "0x27C7510", Offset = "0x27C7611", VA = "0x27C7510")]
		public SolverManager()
		{
		}

		// Token: 0x0400B21D RID: 45597
		[Token(Token = "0x40085A2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177470", Offset = "0x177571")]
		public bool fixTransforms;

		// Token: 0x0400B21E RID: 45598
		[Token(Token = "0x40085A3")]
		[FieldOffset(Offset = "0x20")]
		private Animator animator;

		// Token: 0x0400B21F RID: 45599
		[Token(Token = "0x40085A4")]
		[FieldOffset(Offset = "0x28")]
		private Animation legacy;

		// Token: 0x0400B220 RID: 45600
		[Token(Token = "0x40085A5")]
		[FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		// Token: 0x0400B221 RID: 45601
		[Token(Token = "0x40085A6")]
		[FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		// Token: 0x0400B222 RID: 45602
		[Token(Token = "0x40085A7")]
		[FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;
	}
}
