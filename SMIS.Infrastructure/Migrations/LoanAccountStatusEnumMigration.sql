-- Migration: Update LoanAccount Status from string to enum (int)
-- Run this in your database or create EF Core migration

-- Step 1: Add new column
ALTER TABLE LoanAccounts ADD COLUMN StatusNew INTEGER DEFAULT 1;

-- Step 2: Migrate data
UPDATE LoanAccounts 
SET StatusNew = CASE 
    WHEN Status = 'Paid' THEN 3
    WHEN Status = 'PartiallyPaid' THEN 2
    WHEN Status = 'Overdue' THEN 4
    ELSE 1  -- Unpaid/Active
END;

-- Step 3: Drop old column
ALTER TABLE LoanAccounts DROP COLUMN Status;

-- Step 4: Rename new column
ALTER TABLE LoanAccounts RENAME COLUMN StatusNew TO Status;
