<?php

/* :project:create.html.twig */
class __TwigTemplate_554ce2a565e3f40b5aec014ba1dafbebaf1d412fdc82eed325a73c6bf41a5acb extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":project:create.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_f92cc34d7ea465c93d61b666b01621a311a67fef1155529d47d64d138faa949c = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f92cc34d7ea465c93d61b666b01621a311a67fef1155529d47d64d138faa949c->enter($__internal_f92cc34d7ea465c93d61b666b01621a311a67fef1155529d47d64d138faa949c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":project:create.html.twig"));

        $__internal_573d8216041a605c25a3e7d27eeb3b156208c1d8ce5e525580daea26ca6e2ae5 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_573d8216041a605c25a3e7d27eeb3b156208c1d8ce5e525580daea26ca6e2ae5->enter($__internal_573d8216041a605c25a3e7d27eeb3b156208c1d8ce5e525580daea26ca6e2ae5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":project:create.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_f92cc34d7ea465c93d61b666b01621a311a67fef1155529d47d64d138faa949c->leave($__internal_f92cc34d7ea465c93d61b666b01621a311a67fef1155529d47d64d138faa949c_prof);

        
        $__internal_573d8216041a605c25a3e7d27eeb3b156208c1d8ce5e525580daea26ca6e2ae5->leave($__internal_573d8216041a605c25a3e7d27eeb3b156208c1d8ce5e525580daea26ca6e2ae5_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_87beab4e00fa112d5560559dc3765d8c6854b50914d3cdcf30a4f710189e8c88 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_87beab4e00fa112d5560559dc3765d8c6854b50914d3cdcf30a4f710189e8c88->enter($__internal_87beab4e00fa112d5560559dc3765d8c6854b50914d3cdcf30a4f710189e8c88_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_e7bd60d9809b7cd5678535057052d455b40180275cceab40543ea787f50eb8c0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e7bd60d9809b7cd5678535057052d455b40180275cceab40543ea787f50eb8c0->enter($__internal_e7bd60d9809b7cd5678535057052d455b40180275cceab40543ea787f50eb8c0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Create Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"></textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Create Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 26
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_e7bd60d9809b7cd5678535057052d455b40180275cceab40543ea787f50eb8c0->leave($__internal_e7bd60d9809b7cd5678535057052d455b40180275cceab40543ea787f50eb8c0_prof);

        
        $__internal_87beab4e00fa112d5560559dc3765d8c6854b50914d3cdcf30a4f710189e8c88->leave($__internal_87beab4e00fa112d5560559dc3765d8c6854b50914d3cdcf30a4f710189e8c88_prof);

    }

    public function getTemplateName()
    {
        return ":project:create.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 26,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Create Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"></textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Create Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}", ":project:create.html.twig", "C:\\Exam 03-Jan-2018\\PHP-Skeleton\\app/Resources\\views/project/create.html.twig");
    }
}
