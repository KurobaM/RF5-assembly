using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D61 RID: 3425
	[Token(Token = "0x20008CD")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x148600", Offset = "0x148701")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148600", Offset = "0x148701")]
	public class InteractionSystem : MonoBehaviour
	{
		// Token: 0x060058C5 RID: 22725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600499E")]
		[Address(RVA = "0x2CDE4B0", Offset = "0x2CDE5B1", VA = "0x2CDE4B0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AAEC0", Offset = "0x1AAFC1")]
		private void OpenUserManual()
		{
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600499F")]
		[Address(RVA = "0x2CDE500", Offset = "0x2CDE601", VA = "0x2CDE500")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AAF00", Offset = "0x1AB001")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A0")]
		[Address(RVA = "0x2CDE550", Offset = "0x2CDE651", VA = "0x2CDE550")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AAF40", Offset = "0x1AB041")]
		private void OpenTutorial1()
		{
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A1")]
		[Address(RVA = "0x2CDE5A0", Offset = "0x2CDE6A1", VA = "0x2CDE5A0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AAF80", Offset = "0x1AB081")]
		private void OpenTutorial2()
		{
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A2")]
		[Address(RVA = "0x2CDE5F0", Offset = "0x2CDE6F1", VA = "0x2CDE5F0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AAFC0", Offset = "0x1AB0C1")]
		private void OpenTutorial3()
		{
		}

		// Token: 0x060058CA RID: 22730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A3")]
		[Address(RVA = "0x2CDE640", Offset = "0x2CDE741", VA = "0x2CDE640")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB000", Offset = "0x1AB101")]
		private void OpenTutorial4()
		{
		}

		// Token: 0x060058CB RID: 22731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A4")]
		[Address(RVA = "0x2CDE690", Offset = "0x2CDE791", VA = "0x2CDE690")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB040", Offset = "0x1AB141")]
		private void SupportGroup()
		{
		}

		// Token: 0x060058CC RID: 22732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A5")]
		[Address(RVA = "0x2CDE6E0", Offset = "0x2CDE7E1", VA = "0x2CDE6E0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB080", Offset = "0x1AB181")]
		private void ASThread()
		{
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060058CD RID: 22733 RVA: 0x0001D328 File Offset: 0x0001B528
		[Token(Token = "0x170008E9")]
		public bool inInteraction
		{
			[Token(Token = "0x60049A6")]
			[Address(RVA = "0x2CDE730", Offset = "0x2CDE831", VA = "0x2CDE730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x0001D340 File Offset: 0x0001B540
		[Token(Token = "0x60049A7")]
		[Address(RVA = "0x2CDE930", Offset = "0x2CDEA31", VA = "0x2CDE930")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		// Token: 0x060058CF RID: 22735 RVA: 0x0001D358 File Offset: 0x0001B558
		[Token(Token = "0x60049A8")]
		[Address(RVA = "0x2CDEA60", Offset = "0x2CDEB61", VA = "0x2CDEA60")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		// Token: 0x060058D0 RID: 22736 RVA: 0x0001D370 File Offset: 0x0001B570
		[Token(Token = "0x60049A9")]
		[Address(RVA = "0x2CDEB90", Offset = "0x2CDEC91", VA = "0x2CDEB90")]
		public bool IsPaused()
		{
			return default(bool);
		}

		// Token: 0x060058D1 RID: 22737 RVA: 0x0001D388 File Offset: 0x0001B588
		[Token(Token = "0x60049AA")]
		[Address(RVA = "0x2CDECB0", Offset = "0x2CDEDB1", VA = "0x2CDECB0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		// Token: 0x060058D2 RID: 22738 RVA: 0x0001D3A0 File Offset: 0x0001B5A0
		[Token(Token = "0x60049AB")]
		[Address(RVA = "0x2CDEE10", Offset = "0x2CDEF11", VA = "0x2CDEE10")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		// Token: 0x060058D3 RID: 22739 RVA: 0x0001D3B8 File Offset: 0x0001B5B8
		[Token(Token = "0x60049AC")]
		[Address(RVA = "0x2CDEF30", Offset = "0x2CDF031", VA = "0x2CDEF30")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x0001D3D0 File Offset: 0x0001B5D0
		[Token(Token = "0x60049AD")]
		[Address(RVA = "0x2CDEFC0", Offset = "0x2CDF0C1", VA = "0x2CDEFC0")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		// Token: 0x060058D5 RID: 22741 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
		[Token(Token = "0x60049AE")]
		[Address(RVA = "0x2CDF050", Offset = "0x2CDF151", VA = "0x2CDF050")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049AF")]
		[Address(RVA = "0x2CDF0E0", Offset = "0x2CDF1E1", VA = "0x2CDF0E0")]
		public void PauseAll()
		{
		}

		// Token: 0x060058D7 RID: 22743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049B0")]
		[Address(RVA = "0x2CDF160", Offset = "0x2CDF261", VA = "0x2CDF160")]
		public void ResumeAll()
		{
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049B1")]
		[Address(RVA = "0x2CDF1E0", Offset = "0x2CDF2E1", VA = "0x2CDF1E0")]
		public void StopAll()
		{
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049B2")]
		[Address(RVA = "0x2CDF250", Offset = "0x2CDF351", VA = "0x2CDF250")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x0001D400 File Offset: 0x0001B600
		[Token(Token = "0x60049B3")]
		[Address(RVA = "0x2CDF2F0", Offset = "0x2CDF3F1", VA = "0x2CDF2F0")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return 0f;
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x0001D418 File Offset: 0x0001B618
		[Token(Token = "0x60049B4")]
		[Address(RVA = "0x2CDF400", Offset = "0x2CDF501", VA = "0x2CDF400")]
		public float GetMinActiveProgress()
		{
			return 0f;
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x0001D430 File Offset: 0x0001B630
		[Token(Token = "0x60049B5")]
		[Address(RVA = "0x2CDF590", Offset = "0x2CDF691", VA = "0x2CDF590")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x0001D448 File Offset: 0x0001B648
		[Token(Token = "0x60049B6")]
		[Address(RVA = "0x2CDF840", Offset = "0x2CDF941", VA = "0x2CDF840")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		// Token: 0x060058DE RID: 22750 RVA: 0x0001D460 File Offset: 0x0001B660
		[Token(Token = "0x60049B7")]
		[Address(RVA = "0x2CDFA30", Offset = "0x2CDFB31", VA = "0x2CDFA30")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		// Token: 0x060058DF RID: 22751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049B8")]
		[Address(RVA = "0x2CDFCB0", Offset = "0x2CDFDB1", VA = "0x2CDFCB0")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		// Token: 0x060058E0 RID: 22752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049B9")]
		[Address(RVA = "0x2CDFFE0", Offset = "0x2CE00E1", VA = "0x2CDFFE0")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		// Token: 0x060058E1 RID: 22753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BA")]
		[Address(RVA = "0x2CE0030", Offset = "0x2CE0131", VA = "0x2CE0030")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		// Token: 0x060058E2 RID: 22754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BB")]
		[Address(RVA = "0x2CE00B0", Offset = "0x2CE01B1", VA = "0x2CE00B0")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BC")]
		[Address(RVA = "0x2CE0200", Offset = "0x2CE0301", VA = "0x2CE0200")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x0001D478 File Offset: 0x0001B678
		[Token(Token = "0x60049BD")]
		[Address(RVA = "0x2CE03A0", Offset = "0x2CE04A1", VA = "0x2CE03A0")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BE")]
		[Address(RVA = "0x2CE0650", Offset = "0x2CE0751", VA = "0x2CE0650")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x0001D490 File Offset: 0x0001B690
		[Token(Token = "0x60049BF")]
		[Address(RVA = "0x2CDFDE0", Offset = "0x2CDFEE1", VA = "0x2CDFDE0")]
		public int GetClosestTriggerIndex()
		{
			return 0;
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060058E7 RID: 22759 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058E8 RID: 22760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008EA")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60049C0")]
			[Address(RVA = "0x2CE07A0", Offset = "0x2CE08A1", VA = "0x2CE07A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049C1")]
			[Address(RVA = "0x2CE07B0", Offset = "0x2CE08B1", VA = "0x2CE07B0")]
			set
			{
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060058E9 RID: 22761 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058EA RID: 22762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008EB")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60049C2")]
			[Address(RVA = "0x2CE07C0", Offset = "0x2CE08C1", VA = "0x2CE07C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AB0C0", Offset = "0x1AB1C1")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049C3")]
			[Address(RVA = "0x2CE07D0", Offset = "0x2CE08D1", VA = "0x2CE07D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AB0D0", Offset = "0x1AB1D1")]
			private set
			{
			}
		}

		// Token: 0x060058EB RID: 22763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C4")]
		[Address(RVA = "0x2CE07E0", Offset = "0x2CE08E1", VA = "0x2CE07E0")]
		public void Start()
		{
		}

		// Token: 0x060058EC RID: 22764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C5")]
		[Address(RVA = "0x2CE0FA0", Offset = "0x2CE10A1", VA = "0x2CE0FA0")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		// Token: 0x060058ED RID: 22765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C6")]
		[Address(RVA = "0x2CE0FC0", Offset = "0x2CE10C1", VA = "0x2CE0FC0")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		// Token: 0x060058EE RID: 22766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C7")]
		[Address(RVA = "0x2CE0FE0", Offset = "0x2CE10E1", VA = "0x2CE0FE0")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		// Token: 0x060058EF RID: 22767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C8")]
		[Address(RVA = "0x2CE1000", Offset = "0x2CE1101", VA = "0x2CE1000")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		// Token: 0x060058F0 RID: 22768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C9")]
		[Address(RVA = "0x2CE10E0", Offset = "0x2CE11E1", VA = "0x2CE10E0")]
		public void OnTriggerEnter(Collider c)
		{
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049CA")]
		[Address(RVA = "0x2CE1200", Offset = "0x2CE1301", VA = "0x2CE1200")]
		public void OnTriggerExit(Collider c)
		{
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
		[Token(Token = "0x60049CB")]
		[Address(RVA = "0x2CE1300", Offset = "0x2CE1401", VA = "0x2CE1300")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		// Token: 0x060058F3 RID: 22771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049CC")]
		[Address(RVA = "0x2CE14D0", Offset = "0x2CE15D1", VA = "0x2CE14D0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060058F4 RID: 22772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049CD")]
		[Address(RVA = "0x2CE15F0", Offset = "0x2CE16F1", VA = "0x2CE15F0")]
		public void Update()
		{
		}

		// Token: 0x060058F5 RID: 22773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049CE")]
		[Address(RVA = "0x2CE1840", Offset = "0x2CE1941", VA = "0x2CE1840")]
		private void Raycasting()
		{
		}

		// Token: 0x060058F6 RID: 22774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049CF")]
		[Address(RVA = "0x2CE0D00", Offset = "0x2CE0E01", VA = "0x2CE0D00")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D0")]
		[Address(RVA = "0x2CE1980", Offset = "0x2CE1A81", VA = "0x2CE1980")]
		private void UpdateEffectors()
		{
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D1")]
		[Address(RVA = "0x2CE1AB0", Offset = "0x2CE1BB1", VA = "0x2CE1AB0")]
		private void OnPreFBBIK()
		{
		}

		// Token: 0x060058F9 RID: 22777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D2")]
		[Address(RVA = "0x2CE1B50", Offset = "0x2CE1C51", VA = "0x2CE1B50")]
		private void OnPostFBBIK()
		{
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D3")]
		[Address(RVA = "0x2CE1C30", Offset = "0x2CE1D31", VA = "0x2CE1C30")]
		private void OnFixTransforms()
		{
		}

		// Token: 0x060058FB RID: 22779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D4")]
		[Address(RVA = "0x2CE1C50", Offset = "0x2CE1D51", VA = "0x2CE1C50")]
		private void OnDestroy()
		{
		}

		// Token: 0x060058FC RID: 22780 RVA: 0x0001D4C0 File Offset: 0x0001B6C0
		[Token(Token = "0x60049D5")]
		[Address(RVA = "0x2CDE850", Offset = "0x2CDE951", VA = "0x2CDE850")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		// Token: 0x060058FD RID: 22781 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
		[Token(Token = "0x60049D6")]
		[Address(RVA = "0x2CDF730", Offset = "0x2CDF831", VA = "0x2CDF730")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		// Token: 0x060058FE RID: 22782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049D7")]
		[Address(RVA = "0x2CE2020", Offset = "0x2CE2121", VA = "0x2CE2020")]
		public InteractionSystem()
		{
		}

		// Token: 0x0400B836 RID: 47158
		[Token(Token = "0x40089F6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B280", Offset = "0x17B381")]
		public string targetTag;

		// Token: 0x0400B837 RID: 47159
		[Token(Token = "0x40089F7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B2C0", Offset = "0x17B3C1")]
		public float fadeInTime;

		// Token: 0x0400B838 RID: 47160
		[Token(Token = "0x40089F8")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B300", Offset = "0x17B401")]
		public float speed;

		// Token: 0x0400B839 RID: 47161
		[Token(Token = "0x40089F9")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B340", Offset = "0x17B441")]
		public float resetToDefaultsSpeed;

		// Token: 0x0400B83A RID: 47162
		[Token(Token = "0x40089FA")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17B380", Offset = "0x17B481")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B380", Offset = "0x17B481")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x17B380", Offset = "0x17B481")]
		public Collider characterCollider;

		// Token: 0x0400B83B RID: 47163
		[Token(Token = "0x40089FB")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B410", Offset = "0x17B511")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x17B410", Offset = "0x17B511")]
		public Transform FPSCamera;

		// Token: 0x0400B83C RID: 47164
		[Token(Token = "0x40089FC")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B470", Offset = "0x17B571")]
		public LayerMask camRaycastLayers;

		// Token: 0x0400B83D RID: 47165
		[Token(Token = "0x40089FD")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B4B0", Offset = "0x17B5B1")]
		public float camRaycastDistance;

		// Token: 0x0400B83E RID: 47166
		[Token(Token = "0x40089FE")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17B4F0", Offset = "0x17B5F1")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		// Token: 0x0400B83F RID: 47167
		[Token(Token = "0x40089FF")]
		[FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		// Token: 0x0400B840 RID: 47168
		[Token(Token = "0x4008A00")]
		[FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		// Token: 0x0400B841 RID: 47169
		[Token(Token = "0x4008A01")]
		[FieldOffset(Offset = "0x60")]
		public InteractionSystem.InteractionDelegate OnInteractionStart;

		// Token: 0x0400B842 RID: 47170
		[Token(Token = "0x4008A02")]
		[FieldOffset(Offset = "0x68")]
		public InteractionSystem.InteractionDelegate OnInteractionPause;

		// Token: 0x0400B843 RID: 47171
		[Token(Token = "0x4008A03")]
		[FieldOffset(Offset = "0x70")]
		public InteractionSystem.InteractionDelegate OnInteractionPickUp;

		// Token: 0x0400B844 RID: 47172
		[Token(Token = "0x4008A04")]
		[FieldOffset(Offset = "0x78")]
		public InteractionSystem.InteractionDelegate OnInteractionResume;

		// Token: 0x0400B845 RID: 47173
		[Token(Token = "0x4008A05")]
		[FieldOffset(Offset = "0x80")]
		public InteractionSystem.InteractionDelegate OnInteractionStop;

		// Token: 0x0400B846 RID: 47174
		[Token(Token = "0x4008A06")]
		[FieldOffset(Offset = "0x88")]
		public InteractionSystem.InteractionEventDelegate OnInteractionEvent;

		// Token: 0x0400B847 RID: 47175
		[Token(Token = "0x4008A07")]
		[FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		// Token: 0x0400B848 RID: 47176
		[Token(Token = "0x4008A08")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x17B500", Offset = "0x17B601")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B500", Offset = "0x17B601")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		// Token: 0x0400B849 RID: 47177
		[Token(Token = "0x4008A09")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B560", Offset = "0x17B661")]
		public InteractionLookAt lookAt;

		// Token: 0x0400B84A RID: 47178
		[Token(Token = "0x4008A0A")]
		[FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		// Token: 0x0400B84B RID: 47179
		[Token(Token = "0x4008A0B")]
		[FieldOffset(Offset = "0xD8")]
		private bool initiated;

		// Token: 0x0400B84C RID: 47180
		[Token(Token = "0x4008A0C")]
		[FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		// Token: 0x0400B84D RID: 47181
		[Token(Token = "0x4008A0D")]
		[FieldOffset(Offset = "0xE8")]
		private Collider c;

		// Token: 0x02000D62 RID: 3426
		// (Invoke) Token: 0x06005900 RID: 22784
		[Token(Token = "0x200140B")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		// Token: 0x02000D63 RID: 3427
		// (Invoke) Token: 0x06005904 RID: 22788
		[Token(Token = "0x200140C")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);
	}
}
