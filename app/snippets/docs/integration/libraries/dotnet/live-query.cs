await using var liveQuery = await db.LiveQuery<Person>("LIVE SELECT * FROM person;");

// Consume the live query...