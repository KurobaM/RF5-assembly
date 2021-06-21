using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace SplineMesh
{
	// Token: 0x02000E3B RID: 3643
	[Token(Token = "0x2000950")]
	[Attribute(Name = "DisallowMultipleComponent", RVA = "0x1490A0", Offset = "0x1491A1")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x1490A0", Offset = "0x1491A1")]
	public class Spline : MonoBehaviour
	{
		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06005FDA RID: 24538 RVA: 0x000201F0 File Offset: 0x0001E3F0
		// (set) Token: 0x06005FDB RID: 24539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009D0")]
		public bool IsLoop
		{
			[Token(Token = "0x6004F4B")]
			[Address(RVA = "0x23807D0", Offset = "0x23808D1", VA = "0x23807D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F4C")]
			[Address(RVA = "0x23807E0", Offset = "0x23808E1", VA = "0x23807E0")]
			set
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06005FDC RID: 24540 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005FDD RID: 24541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000008")]
		public event ListChangeHandler<SplineNode> NodeListChanged
		{
			[Token(Token = "0x6004F4D")]
			[Address(RVA = "0x2380B70", Offset = "0x2380C71", VA = "0x2380B70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC660", Offset = "0x1AC761")]
			add
			{
			}
			[Token(Token = "0x6004F4E")]
			[Address(RVA = "0x2380C20", Offset = "0x2380D21", VA = "0x2380C20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC670", Offset = "0x1AC771")]
			remove
			{
			}
		}

		// Token: 0x06005FDE RID: 24542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F4F")]
		[Address(RVA = "0x2380CD0", Offset = "0x2380DD1", VA = "0x2380CD0")]
		private void Reset()
		{
		}

		// Token: 0x06005FDF RID: 24543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F50")]
		[Address(RVA = "0x2381070", Offset = "0x2381171", VA = "0x2381070")]
		private void OnEnable()
		{
		}

		// Token: 0x06005FE0 RID: 24544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F51")]
		[Address(RVA = "0x2381280", Offset = "0x2381381", VA = "0x2381280")]
		public ReadOnlyCollection<CubicBezierCurve> GetCurves()
		{
			return null;
		}

		// Token: 0x06005FE1 RID: 24545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F52")]
		[Address(RVA = "0x2380ED0", Offset = "0x2380FD1", VA = "0x2380ED0")]
		private void RaiseNodeListChanged(ListChangedEventArgs<SplineNode> args)
		{
		}

		// Token: 0x06005FE2 RID: 24546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F53")]
		[Address(RVA = "0x2380F50", Offset = "0x2381051", VA = "0x2380F50")]
		private void UpdateAfterCurveChanged()
		{
		}

		// Token: 0x06005FE3 RID: 24547 RVA: 0x00020208 File Offset: 0x0001E408
		[Token(Token = "0x6004F54")]
		[Address(RVA = "0x23812E0", Offset = "0x23813E1", VA = "0x23812E0")]
		public CurveSample GetSample(float t)
		{
			return default(CurveSample);
		}

		// Token: 0x06005FE4 RID: 24548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F55")]
		[Address(RVA = "0x23814F0", Offset = "0x23815F1", VA = "0x23814F0")]
		public CubicBezierCurve GetCurve(float t)
		{
			return null;
		}

		// Token: 0x06005FE5 RID: 24549 RVA: 0x00020220 File Offset: 0x0001E420
		[Token(Token = "0x6004F56")]
		[Address(RVA = "0x2381390", Offset = "0x2381491", VA = "0x2381390")]
		private int GetNodeIndexForTime(float t)
		{
			return 0;
		}

		// Token: 0x06005FE6 RID: 24550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F57")]
		[Address(RVA = "0x2381080", Offset = "0x2381181", VA = "0x2381080")]
		public void RefreshCurves()
		{
		}

		// Token: 0x06005FE7 RID: 24551 RVA: 0x00020238 File Offset: 0x0001E438
		[Token(Token = "0x6004F58")]
		[Address(RVA = "0x237D140", Offset = "0x237D241", VA = "0x237D140")]
		public CurveSample GetSampleAtDistance(float d)
		{
			return default(CurveSample);
		}

		// Token: 0x06005FE8 RID: 24552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F59")]
		[Address(RVA = "0x237EE80", Offset = "0x237EF81", VA = "0x237EE80")]
		public void AddNode(SplineNode node)
		{
		}

		// Token: 0x06005FE9 RID: 24553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F5A")]
		[Address(RVA = "0x2381580", Offset = "0x2381681", VA = "0x2381580")]
		public void InsertNode(int index, SplineNode node)
		{
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F5B")]
		[Address(RVA = "0x237F090", Offset = "0x237F191", VA = "0x237F090")]
		public void RemoveNode(SplineNode node)
		{
		}

		// Token: 0x06005FEB RID: 24555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F5C")]
		[Address(RVA = "0x23807F0", Offset = "0x23808F1", VA = "0x23807F0")]
		private void updateLoopBinding()
		{
		}

		// Token: 0x06005FEC RID: 24556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F5D")]
		[Address(RVA = "0x23819A0", Offset = "0x2381AA1", VA = "0x23819A0")]
		private void StartNodeChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06005FED RID: 24557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F5E")]
		[Address(RVA = "0x23820C0", Offset = "0x23821C1", VA = "0x23820C0")]
		private void EndNodeChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06005FEE RID: 24558 RVA: 0x00020250 File Offset: 0x0001E450
		[Token(Token = "0x6004F5F")]
		[Address(RVA = "0x2382570", Offset = "0x2382671", VA = "0x2382570")]
		public CurveSample GetProjectionSample(Vector3 pointToProject)
		{
			return default(CurveSample);
		}

		// Token: 0x06005FEF RID: 24559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F60")]
		[Address(RVA = "0x2382970", Offset = "0x2382A71", VA = "0x2382970")]
		public Spline()
		{
		}

		// Token: 0x0400BEE8 RID: 48872
		[Token(Token = "0x4008EC3")]
		[FieldOffset(Offset = "0x18")]
		public List<SplineNode> nodes;

		// Token: 0x0400BEE9 RID: 48873
		[Token(Token = "0x4008EC4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HideInInspector", RVA = "0x17E6F0", Offset = "0x17E7F1")]
		public List<CubicBezierCurve> curves;

		// Token: 0x0400BEEA RID: 48874
		[Token(Token = "0x4008EC5")]
		[FieldOffset(Offset = "0x28")]
		public float Length;

		// Token: 0x0400BEEB RID: 48875
		[Token(Token = "0x4008EC6")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool isLoop;

		// Token: 0x0400BEED RID: 48877
		[Token(Token = "0x4008EC8")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "HideInInspector", RVA = "0x17E720", Offset = "0x17E821")]
		public UnityEvent CurveChanged;

		// Token: 0x0400BEEE RID: 48878
		[Token(Token = "0x4008EC9")]
		[FieldOffset(Offset = "0x40")]
		private SplineNode start;

		// Token: 0x0400BEEF RID: 48879
		[Token(Token = "0x4008ECA")]
		[FieldOffset(Offset = "0x48")]
		private SplineNode end;
	}
}
