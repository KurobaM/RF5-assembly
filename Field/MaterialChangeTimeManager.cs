using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x02001103 RID: 4355
	[Token(Token = "0x2000AF7")]
	public class MaterialChangeTimeManager : SingletonMonoBehaviour<MaterialChangeTimeManager>
	{
		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06006E23 RID: 28195 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006E24 RID: 28196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF5")]
		public Light Light
		{
			[Token(Token = "0x6005B68")]
			[Address(RVA = "0x202AD30", Offset = "0x202AE31", VA = "0x202AD30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B69")]
			[Address(RVA = "0x202AD40", Offset = "0x202AE41", VA = "0x202AD40")]
			set
			{
			}
		}

		// Token: 0x06006E25 RID: 28197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6A")]
		[Address(RVA = "0x202A820", Offset = "0x202A921", VA = "0x202A820")]
		public void AddMaterialChangeTime(TimeParamTable timeParamTable, MaterialChangeTime materialChangeTime)
		{
		}

		// Token: 0x06006E26 RID: 28198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6B")]
		[Address(RVA = "0x202A690", Offset = "0x202A791", VA = "0x202A690")]
		public void RemoveMaterialChangeTime(TimeParamTable timeParamTable, MaterialChangeTime materialChangeTime)
		{
		}

		// Token: 0x06006E27 RID: 28199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6C")]
		[Address(RVA = "0x202AE50", Offset = "0x202AF51", VA = "0x202AE50")]
		public void AddObjectChangeTime(TimeParamTable timeParamTable, ObjectChangeTime objectChangeTime)
		{
		}

		// Token: 0x06006E28 RID: 28200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6D")]
		[Address(RVA = "0x202AF40", Offset = "0x202B041", VA = "0x202AF40")]
		public void RemoveObjectChangeTime(TimeParamTable timeParamTable, ObjectChangeTime objectChangeTime)
		{
		}

		// Token: 0x06006E29 RID: 28201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6E")]
		[Address(RVA = "0x202B010", Offset = "0x202B111", VA = "0x202B010")]
		public void AddRendererChangeTime(TimeParamTable timeParamTable, RendererChangeTime rendererChangeTime)
		{
		}

		// Token: 0x06006E2A RID: 28202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6F")]
		[Address(RVA = "0x202B100", Offset = "0x202B201", VA = "0x202B100")]
		public void RemoveRendererChangeTime(TimeParamTable timeParamTable, RendererChangeTime rendererChangeTime)
		{
		}

		// Token: 0x06006E2B RID: 28203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B70")]
		[Address(RVA = "0x202B1D0", Offset = "0x202B2D1", VA = "0x202B1D0")]
		private void Start()
		{
		}

		// Token: 0x06006E2C RID: 28204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B71")]
		[Address(RVA = "0x202B240", Offset = "0x202B341", VA = "0x202B240")]
		private void Update()
		{
		}

		// Token: 0x06006E2D RID: 28205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B72")]
		[Address(RVA = "0x202B300", Offset = "0x202B401", VA = "0x202B300")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AEAB0", Offset = "0x1AEBB1")]
		private IEnumerator UpdateObjectCoroutine()
		{
			return null;
		}

		// Token: 0x06006E2E RID: 28206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B73")]
		[Address(RVA = "0x202B3B0", Offset = "0x202B4B1", VA = "0x202B3B0")]
		private void UpdateMaterialParameter(TimeParamTable timeParamTable, HashSet<MaterialChangeTime> materialChangeSet, float dailyRatio)
		{
		}

		// Token: 0x06006E2F RID: 28207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B74")]
		[Address(RVA = "0x202C440", Offset = "0x202C541", VA = "0x202C440")]
		private void UpdateMaterialParameter(TimeParamTable timeParamTable, HashSet<Material> materialSet, float dailyRatio)
		{
		}

		// Token: 0x06006E30 RID: 28208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B75")]
		[Address(RVA = "0x202D100", Offset = "0x202D201", VA = "0x202D100")]
		private void UpdateObjectParameter(TimeParamTable timeParamTable, HashSet<ObjectChangeTime> objectChangeSet, float dailyRatio)
		{
		}

		// Token: 0x06006E31 RID: 28209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B76")]
		[Address(RVA = "0x202D3E0", Offset = "0x202D4E1", VA = "0x202D3E0")]
		private void UpdateRendererParameter(TimeParamTable timeParamTable, HashSet<RendererChangeTime> rendererChangeSet, float dailyRatio)
		{
		}

		// Token: 0x06006E32 RID: 28210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B77")]
		[Address(RVA = "0x202D820", Offset = "0x202D921", VA = "0x202D820")]
		public Material GetChangeMaterial(Material checkMaterial)
		{
			return null;
		}

		// Token: 0x06006E33 RID: 28211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B78")]
		[Address(RVA = "0x202D830", Offset = "0x202D931", VA = "0x202D830")]
		public MaterialChangeTimeManager()
		{
		}

		// Token: 0x040180DC RID: 98524
		[Token(Token = "0x4014BB9")]
		private const int MaterialChangeFrameCount = 3;

		// Token: 0x040180DD RID: 98525
		[Token(Token = "0x4014BBA")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<TimeParamTable, HashSet<Material>> TimeParamMaterialDict;

		// Token: 0x040180DE RID: 98526
		[Token(Token = "0x4014BBB")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<TimeParamTable, HashSet<MaterialChangeTime>> TimeParamMaterialChangeDict;

		// Token: 0x040180DF RID: 98527
		[Token(Token = "0x4014BBC")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<TimeParamTable, HashSet<ObjectChangeTime>> TimeParamObjectChangeDict;

		// Token: 0x040180E0 RID: 98528
		[Token(Token = "0x4014BBD")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<TimeParamTable, HashSet<RendererChangeTime>> TimeParamRendererChangeDict;

		// Token: 0x040180E1 RID: 98529
		[Token(Token = "0x4014BBE")]
		[FieldOffset(Offset = "0x38")]
		private Light _Light;

		// Token: 0x040180E2 RID: 98530
		[Token(Token = "0x4014BBF")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine UpdateCoroutine;

		// Token: 0x02001104 RID: 4356
		[Token(Token = "0x2001578")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A110", Offset = "0x15A211")]
		private sealed class <UpdateObjectCoroutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006E34 RID: 28212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D6A")]
			[Address(RVA = "0x202B380", Offset = "0x202B481", VA = "0x202B380")]
			[DebuggerHidden]
			public <UpdateObjectCoroutine>d__18(int <>1__state)
			{
			}

			// Token: 0x06006E35 RID: 28213 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D6B")]
			[Address(RVA = "0x202D950", Offset = "0x202DA51", VA = "0x202D950", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006E36 RID: 28214 RVA: 0x00025EA8 File Offset: 0x000240A8
			[Token(Token = "0x6007D6C")]
			[Address(RVA = "0x202D960", Offset = "0x202DA61", VA = "0x202D960", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DFC RID: 3580
			// (get) Token: 0x06006E37 RID: 28215 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC1")]
			private object Current
			{
				[Token(Token = "0x6007D6D")]
				[Address(RVA = "0x202DE20", Offset = "0x202DF21", VA = "0x202DE20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006E38 RID: 28216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D6E")]
			[Address(RVA = "0x202DE30", Offset = "0x202DF31", VA = "0x202DE30", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DFD RID: 3581
			// (get) Token: 0x06006E39 RID: 28217 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC2")]
			private object Current
			{
				[Token(Token = "0x6007D6F")]
				[Address(RVA = "0x202DE90", Offset = "0x202DF91", VA = "0x202DE90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040180E3 RID: 98531
			[Token(Token = "0x401C12F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040180E4 RID: 98532
			[Token(Token = "0x401C130")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040180E5 RID: 98533
			[Token(Token = "0x401C131")]
			[FieldOffset(Offset = "0x20")]
			public MaterialChangeTimeManager <>4__this;
		}
	}
}
