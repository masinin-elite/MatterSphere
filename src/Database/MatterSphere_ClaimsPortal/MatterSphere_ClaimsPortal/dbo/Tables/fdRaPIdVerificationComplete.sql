﻿CREATE TABLE [dbo].[fdRaPIdVerificationComplete](
	[fileID] [bigint] NOT NULL,
	[rpdProgClaimantComplete] [bit] NULL,
	[rpdProgDefendantComplete] [bit] NULL,
	[rpdProgAccident1Complete] [bit] NULL,
	[rpdProgAccident2Complete] [bit] NULL,
	[rpdProgVehicleComplete] [bit] NULL,
	[rpdProgLiabilityComplete] [bit] NULL,
	[rpdProgOthPartysComplete] [bit] NULL,
	[rpdProgMedicalComplete] [bit] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [DF_fdRaPIdVerificationComplete_rowguid]  DEFAULT (newid()),
	rpdProgIntPayReqComplete BIT NULL,
	rpdProgIntSetPakComplete BIT NULL,
	rpdProgResubmitComplete BIT NULL,
	rpdProgLiabDenComplete BIT NULL,
	rpdProgPayRecvdComplete BIT NULL,
	rpdProgIntPayRecComplete BIT NULL,
	rpdProgIntPartialComplte BIT NULL,
	rpdProgSetPackComplete BIT NULL,
	rpdProgSetConfComplete BIT NULL,
	rpdProgSetRepuComplete BIT NULL,
	rpdProgSetAgreementDec BIT NULL,
	rpdProgLiabAckChildAdmit BIT NULL,
	rpdProgLiabAckNegligence BIT NULL,
	rpdProgISPAckTimeout BIT NULL,
	rpdProgISPAckRejection BIT NULL,
	rpdProgSPNotAgreed BIT NULL,
	rpdProgSPAgreed BIT NULL,
	rpdProgSPAddDamExist BIT NULL,
	rpdProgSPAddDamDecision BIT NULL,
	rpdProgSPAddDamAll BIT NULL,
	rpdProgSPAddDamAck BIT NULL,
	rpdProgSPAddDamDecTO BIT NULL,
	rpdProgSPAddDamReq BIT NULL,
	rpdProgLiabDecTO BIT NULL,
    rpdProgSetCOComplete BIT NULL,
    rpdProgSetCONeeded BIT NULL,
	rpdProgLiabDecAck BIT NULL,
	rpdProgRejClaimAck BIT NULL,
	rpdProgRejClaimExit BIT NULL,
 CONSTRAINT [PK_fdRaPIdVerificationComplete] PRIMARY KEY CLUSTERED 
(
	[fileID] ASC
)
)
