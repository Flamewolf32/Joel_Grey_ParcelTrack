# ParcelTrack (starter)

CWEB2302 Web Development II, Common Coursework (Individual).

## Run it
1. Open `ParcelTrack.csproj` in Visual Studio.
2. Package Manager Console: `Update-Database`.
3. F5 (the **http** profile, http://localhost:5420), then open `/parcels`. Five parcels show.

## Demo accounts (made when the app starts)
| Email | Password | Role |
|---|---|---|
| admin@parceltrack.test | Pass123! | Admin |
| staff@parceltrack.test | Pass123! | Staff |

## What the starter already does
- Parcels and Branches tables (a foreign key), seeded, one migration
- Pages: `/parcels`, `/parcels/{id}`, add, edit, delete, `/branches/{id}`
- Identity with Admin and Staff roles: Staff add and edit, only the Admin deletes
- A JSON API at `/api/parcels` (GET, POST, PUT, DELETE) with a DTO. **Not locked yet.**

## My work
Did Parts A to G.

Part D lifetime: Singleton, because the fee calculator doesn't store anything or use the database, so one copy can be shared.

Nothing I know of is broken.
