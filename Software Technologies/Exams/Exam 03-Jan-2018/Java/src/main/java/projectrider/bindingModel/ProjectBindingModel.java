package projectrider.bindingModel;

import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;

public class ProjectBindingModel {
    @NotNull
    @Size(min=1)
    private String title;

    @NotNull
    @Size(min=1)
    private String description;

    private long budget;

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public long getBudget() {
        return budget;
    }

    public void setBudget(long budget) {
        this.budget = budget;
    }
}
